﻿using Coffee_Ecommerce.WebApp.Services.Interfaces;
using Coffee_Ecommerce.WebApp.ThirdParty.GoogleCloud.MapsPlatform;
using Coffee_Ecommerce.WebApp.ThirdParty.GoogleCloud.MapsPlatform.Clients;
using System.Text.RegularExpressions;

namespace Coffee_Ecommerce.WebApp.Services
{
    public sealed class AddressService : IAddressService
    {
        private readonly string _accessKey;
        private readonly IGeocodingClient _client = RestService.For<IGeocodingClient>("https://maps.googleapis.com/maps/api");

        public AddressService(IConfiguration config)
        {
            _accessKey = config["GoogleCloud"]!;
        }

        public async Task<GeocodeResponse?> ValidatePostalCode(string postalCode)
        {
            string _postalCode = FormatPostalCode(postalCode);

            if (string.IsNullOrWhiteSpace(_postalCode))
                return null;

            if (_postalCode.Length != 8)
                return null;

            try
            {
                var response = await _client.GetLocationAsync(_accessKey, _postalCode);
         
                if (response.Status != "OK")
                    return null;

                if (response.Results[0].AddressComponents[5].ShortName != "BR")
                    return null;

                return response;
            }
            catch (ApiException)
            {
                throw;
            }
        }

        public string FormatPostalCode(string postalCode)
        {
            return Regex.Replace(postalCode, @"[^\d]+", "");
        }
    }
}
