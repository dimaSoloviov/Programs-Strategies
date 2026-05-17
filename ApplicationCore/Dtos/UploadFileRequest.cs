using Microsoft.AspNetCore.Http;

namespace ApplicationCore.Dtos;

public class UploadFileRequest
{
    public IFormFile File { get; set; } = null!;
}