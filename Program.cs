// using Microsoft.AspNetCore.Components.Web;
// using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
// using ClothingStore;



// var builder = WebAssemblyHostBuilder.CreateDefault(args);
// builder.RootComponents.Add<App>("#app");
// builder.RootComponents.Add<HeadOutlet>("head::after");

// builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

// await builder.Build().RunAsync();

using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using ClothingStore;
using ClothingStore.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

// Đăng ký các dịch vụ
builder.Services.AddSingleton<CartService>();
builder.Services.AddSingleton<OrderService>();
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

// Đăng ký các RootComponents
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// Xây dựng ứng dụng và chạy
var app = builder.Build();

// Đảm bảo rằng bạn chỉ gọi RunAsync một lần
await app.RunAsync();
