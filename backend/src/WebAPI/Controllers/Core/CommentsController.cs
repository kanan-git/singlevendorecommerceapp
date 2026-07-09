using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Business.Services.Abstract;
using Entities.DTOs.Comment;
using Microsoft.AspNetCore.Authorization;

namespace WebAPI.Controllers;

[ApiController]
[Route("api/[controller]/[action]")]
public class CommentsController : ControllerBase
{
    private readonly ICommentServices _commentService;
    public CommentsController(ICommentServices commentService)
    {
        _commentService = commentService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllComments()
    {
        var data = await _commentService.GetAllCommentsAsync();
        if(data.Success)
        {
            return Ok(data);
        }
        return BadRequest(data);
    }

    [HttpGet("{page}")]
    public async Task<IActionResult> GetAllCommentsPaginated(int page, int size)
    {
        var data = await _commentService.GetAllCommentsPaginatedAsync(page, size);
        if(data.Success)
        {
            return Ok(data);
        }
        return BadRequest(data);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetCommentById(Guid id)
    {
        var data = await _commentService.GetCommentByIdAsync(id);
        if(data.Success)
        {
            return Ok(data);
        }
        return BadRequest(data);
    }

    [HttpPost]
    [Authorize(Roles="Admin, User")]
    public async Task<IActionResult> CreateComment(CommentCreateDto commentDto)
    {
        var result = await _commentService.AddNewCommentAsync(commentDto);
        if(result.Success)
        {
            return Ok(result);
        }
        return BadRequest(result);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateComment(Guid id, CommentUpdateDto commentDto)
    {
        var result = await _commentService.UpdateComment(id, commentDto);
        if(result.Success)
        {
            return Ok(result);
        }
        return BadRequest(result);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> RemoveComment(Guid id)
    {
        var result = await _commentService.DeleteComment(id);
        if(result.Success)
        {
            return Ok(result);
        }
        return BadRequest(result);
    }
}
