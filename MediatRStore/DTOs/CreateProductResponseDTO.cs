namespace MediatRStore.DTOs;

public class CreateProductResponseDTO
{
    public int StatusCode { get; set; }
    public bool Successful { get; set; }
    public string Message { get; set; }
}