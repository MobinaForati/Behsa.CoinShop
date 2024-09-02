﻿namespace Behsa.CoinShop.Domain.Exceptions;

public class UnSupportedPostalCodeException(string postalCode)
    : Exception($"Postalcode \"{postalCode}\" is unsupported.")
{
}