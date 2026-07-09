using Business;
using WebAPI;
using DataAccessLayer;
using Core.Utilities.Constants;


var uploadPath = StaticDirectories.FilesRootDir;
if(!Directory.Exists(uploadPath))
{
    Directory.CreateDirectory(uploadPath);
}

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddWebApiConfig(builder.Configuration);
builder.Services.AddBusinessConfig();
builder.Services.AddDataAccessLayerConfig(builder.Configuration);

var app = builder.Build();
app.UseStaticFiles();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseRouting();
app.UseCors("AllowAllOrigins");
app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();
app.Run();
