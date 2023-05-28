namespace DigiStoreApi.Dtos;

public class ProductDto
{
    public string? Name { get; set; }
    public string? Brand { get; set; }
    public int CurrentQuantity { get; set; }
    public int SafetyStock { get; set; }
    public int ActualStock { get; set; }
    public int OrderQuantity { get; set; }
    public int CategoryId { get; set; }
    public int UnitId { get; set; }
    public int LevelId { get; set; }
    public int Status { get; set; }
}