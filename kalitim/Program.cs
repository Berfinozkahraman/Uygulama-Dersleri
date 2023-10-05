// şirket ürünleri kaydeden, silen ve listeleyen metotlar istiyor

using kalitim;
// 1. Servis

//ProductService productService = new ProductService();
//productService.Add();
//productService.GetList();
//productService.Remove();

//ProductService2 productService2 = new ProductService2();
//productService2.Add();
//productService2.Remove();
//productService2.GetList();

// Polymorphism (çok biçimlilik)
//IProductService ProductService = new ProductService();
//productService.Add();
//productService.Remove();
//productService.GetList();

// Dependency Injection IoC(Inversion of Control) Container

//Matematik matematik = new Matematik(44, 25);
//matematik.Topla();
//matematik.Cikar();

// RentAcar şirketine araba ekleme, silme ve listeleme işlemleri


RentAcarService rentACarService = new RentAcarService();
rentACarService.Add();
rentACarService.Remove();
rentACarService.GetList();

