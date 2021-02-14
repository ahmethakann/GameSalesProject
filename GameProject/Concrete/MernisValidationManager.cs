﻿using GameProject.Entites;
using GameProject.Interfaces;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Methods
{
    class MernisValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(
                new TCKimlikNoDogrulaRequest(
                    new TCKimlikNoDogrulaRequestBody(gamer.IdentityNumber,gamer.FirstName,gamer.LastName,gamer.BirthYear)))
                .Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
