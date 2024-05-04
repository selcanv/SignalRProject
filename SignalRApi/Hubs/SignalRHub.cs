using Microsoft.AspNetCore.SignalR;
using SignalR.DataAccessLayer.Concrete;

namespace SignalRApi.Hubs
{
	//hub burada sunucu görevi görecek
	//dağıtım işlemini hub sınıfım hangisiyse onun üzerinden sağlıcam
	//benim burada hub sınıfım SignalR
	public class SignalRHub:Hub
	{
		SignalRContext context =new SignalRContext();
		public async Task SendCategoryCount()
		{
			var value= context.Categories.Count();
			await Clients.All.SendAsync("ReceiveCategoryCount", value);

		} 
	}
}

//Cors politikası nedir?
//SOP?