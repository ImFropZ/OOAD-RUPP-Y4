using ProductLib;

class ProductHelper {
  private ProductService _productService = new ProductService();

  public string? Create(ProductCreateReq req) {
    return _productService.Create(req);
  }

  public List<ProductResponse> ReadAll() {
    return _productService.ReadAll();
  }

  public ProductResponse? Read(string key) {
    return _productService.Read(key);
  }

  public bool Update(ProductUpdateReq req) {
    return _productService.Update(req);
  }

  public bool Delete(string key) {
    return _productService.Delete(key);
  }

  public List<string?> Initialize() {
    return _productService.Initialize();
  }

  public bool Exist(string key) {
    return _productService.Exist(key);
  }
}