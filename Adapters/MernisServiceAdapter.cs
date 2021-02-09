using GameProject.Abstract;
using GameProject.Entities;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Adapters
{
    public class MernisServiceAdapter : IPlayerCheckService
    {
        public bool checkIfRealPerson(Player player)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(
                new TCKimlikNoDogrulaRequest(
                    new TCKimlikNoDogrulaRequestBody(player.NationalityId, player.FirstName, player.LastName, player.DateOfBirth))).Result.Body.TCKimlikNoDogrulaResult;

        }
    }
}
