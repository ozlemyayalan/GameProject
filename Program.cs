using GameProject.Abstract;
using GameProject.Adapters;
using GameProject.Concrete;
using System;

namespace GameProject
{
    partial class Program
    {
        static void Main(string[] args)
        {
            /*
             * Gereksinimler

            1.Oyuncuların sisteme kayıt olabileceği, bilgilerini güncelleyebileceği, kayıtlarını silebileceği bir ortamı simule ediniz.Müşteri bilgilerinin doğruluğunu e-devlet sistemlerini kullanarak doğrulama yapmak istiyoruz. (E - devlet sistemlerinde doğrulama TcNo, Ad, Soyad, DoğumYılı bilgileriyle yapılır.Bunu yapacak servisi simule etmeniz yeterlidir.)

            2.Oyun satışı yapılabilecek satış ortamını simule ediniz.(Yapılan satışlar oyuncu ile ilişkilendirilmelidir. Oyuncunun parametre olarak metotta olmasını kastediyorum.)

            3.Sisteme yeni kampanya girişi, kampanyanın silinmesi ve güncellenmesi imkanlarını simule ediniz.

            4.Satışlarda kampanya entegrasyonunu simule ediniz.
            
             */



            BasePlayerManager playerManager = new PlayerManager(new MernisServiceAdapter());
            playerManager.RegisterAccount(new Entities.Player { DateOfBirth = 1169, FirstName = "Feanor", LastName = "High King of the Ñoldor", NationalityId = 10000000146 });

            playerManager.UpdateInformation(new Entities.Player { FirstName = "Beren" });
            playerManager.DeleteAccount(new Entities.Player { FirstName = "Luthien" });



            Console.WriteLine("--------------");

            CampaignManager campaignManager = new CampaignManager();

            campaignManager.AddNewCampaign(new Entities.Campaign { CampaignId = 1, CampaignName = "Black Friday", CampaignDiscountRate = 0.4 });
            campaignManager.DeleteCampaign(new Entities.Campaign { CampaignName = "Back to school" });
            campaignManager.UpdateCampaign(new Entities.Campaign { CampaignName = "Valentines day" });




            Console.WriteLine("--------------");



            OrdersManager ordersManager = new OrdersManager();
            ordersManager.Sale(
                new Entities.Game { GameId = 216, GameName = "Neverwinter Nights" },
                new Entities.Player { DateOfBirth = 1169, FirstName = "Feanor", LastName = "High King of the Ñoldor", NationalityId = 10000000146 },
                new Entities.Orders { OrderId = 3515413 },
                new Entities.Campaign { CampaignId = 1, CampaignName = "Gamer Nights", CampaignDiscountRate = 0.2 }

                );





            Console.ReadLine();

        }
    }
}
