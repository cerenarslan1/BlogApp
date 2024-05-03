namespace CoreDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {

            var builder = WebApplication.CreateBuilder(args);
            //Asp.NET Core uygulamas�nda MVC mimarisini kullanab.lmek i�in uygulamada Controller ve view yap�land�rmalar�n�n eklenmesi gerekmektedir.
            //Bunun i�in �ncelikle bu servis uygulamaya ekleniyor.B�ylece uygulama MVC davran���n� sergileyebilecektir.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            //app.MapGet("/", () => "Hello World!");
            //Bir ASP.Net Core uygulamas�nda y�nlendirme i�lemlerini etkinle�tirir.
            app.UseRouting();
            //Endpoint: yap�lan iste�in var�i noktas�. URL istek adresi.
            //Bu uygulamaya gelen isteklerin hangi rotalar/�ablonlar e�li�inde gelebilece�ini burdan bildirece�iz.
            app.UseEndpoints(endpoints =>
            {
                //Endpoint tan�mlanmas�nsa s�sl� parantez i�erisinde parametre tan�mlanabilmektedir. Bu parametreler herhangi birisinde olabilir.
                //Default olan endpoint �emas� v-bu uygulamaya yap�lacak olan istekler bu �emaya uygun bir �ekilde yap�lacakt�r.
                //{controller=Home}/{action=Index}/{id?}
                //a�a��daki �rnekte personel=com-ntroller getir=action id default olarak null 

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