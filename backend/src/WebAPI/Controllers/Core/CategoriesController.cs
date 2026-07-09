using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Business.Services.Abstract;
using Entities.DTOs.Category;
using Microsoft.AspNetCore.Authorization;

namespace WebAPI.Controllers;

[ApiController]
[Route("api/[controller]/[action]")]
public class CategorysController : ControllerBase
{
    private readonly ICategoryServices _categoryService;
    public CategorysController(ICategoryServices categoryService)
    {
        _categoryService = categoryService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllCategorys()
    {
        var data = await _categoryService.GetAllCategoriesAsync();
        if(data.Success)
        {
            return Ok(data);
        }
        return BadRequest(data);
    }

    [HttpGet("{page}")]
    public async Task<IActionResult> GetAllCategorysPaginated(int page, int size)
    {
        var data = await _categoryService.GetAllCategoriesPaginatedAsync(page, size);
        if(data.Success)
        {
            return Ok(data);
        }
        return BadRequest(data);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetCategoryById(Guid id)
    {
        var data = await _categoryService.GetCategoryByIdAsync(id);
        if(data.Success)
        {
            return Ok(data);
        }
        return BadRequest(data);
    }

    [HttpPost]
    [Authorize(Roles="Admin, User")]
    public async Task<IActionResult> CreateCategory(CategoryCreateDto categoryDto)
    {
        var result = await _categoryService.AddNewCategoryAsync(categoryDto);
        if(result.Success)
        {
            return Ok(result);
        }
        return BadRequest(result);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateCategory(Guid id, CategoryUpdateDto categoryDto)
    {
        var result = await _categoryService.UpdateCategory(id, categoryDto);
        if(result.Success)
        {
            return Ok(result);
        }
        return BadRequest(result);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> RemoveCategory(Guid id)
    {
        var result = await _categoryService.DeleteCategory(id);
        if(result.Success)
        {
            return Ok(result);
        }
        return BadRequest(result);
    }
}
