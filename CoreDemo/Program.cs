namespace CoreDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {

            var builder = WebApplication.CreateBuilder(args);
            //Asp.NET Core uygulamasýnda MVC mimarisini kullanab.lmek için uygulamada Controller ve view yapýlandýrmalarýnýn eklenmesi gerekmektedir.
            //Bunun için öncelikle bu servis uygulamaya ekleniyor.Böylece uygulama MVC davranýþýný sergileyebilecektir.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            //app.MapGet("/", () => "Hello World!");
            //Bir ASP.Net Core uygulamasýnda yönlendirme iþlemlerini etkinleþtirir.
            app.UseRouting();
            //Endpoint: yapýlan isteðin varýi noktasý. URL istek adresi.
            //Bu uygulamaya gelen isteklerin hangi rotalar/þablonlar eþliðinde gelebileceðini burdan bildireceðiz.
            app.UseEndpoints(endpoints =>
            {
                //Endpoint tanýmlanmasýnsa süslü parantez içerisinde parametre tanýmlanabilmektedir. Bu parametreler herhangi birisinde olabilir.
                //Default olan endpoint þemasý v-bu uygulamaya yapýlacak olan istekler bu þemaya uygun bir þekilde yapýlacaktýr.
                //{controller=Home}/{action=Index}/{id?}
                //aþaðýdaki örnekte personel=com-ntroller getir=action id default olarak null 

                //https://www.abc..com/personel/getir
                endpoints.MapDefaultControllerRoute();
                //endpoints.MapControllerRoute(
                //    name: "default",
                //    pattern: "{controller=Home}/{action=Index}/{id?}"
                //    );

            });
            app.Run();
        }
    }
}