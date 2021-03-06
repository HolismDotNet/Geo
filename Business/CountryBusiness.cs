namespace Geo;

public class CountryBusiness : Business<Country, Country>
{
    protected override Read<Country> Read => Repository.Country;

    protected override Write<Country> Write => Repository.Country;

    private static Dictionary<Guid, Country> countriesByGuid;

    private static Dictionary<Guid, Country> CountriesByGuid
    {
        get
        {
            if (countriesByGuid == null)
            {
                countriesByGuid = new CountryBusiness().GetAll().ToDictionary(i => i.Guid, i => i);
            }
            return countriesByGuid;
        }
    }

    protected override void ModifyItemBeforeReturning(Country item)
    {
        if (item.IsoTwoLetterCode.IsSomething())
        {
            item.RelatedItems.OneByOneFlagRelativeUrl = $"/images/flags/oneByOne/{item.IsoTwoLetterCode.ToLower()}.svg";
            item.RelatedItems.FourByThreeFlagRelativeUrl = $"/images/flags/fourByThree/{item.IsoTwoLetterCode.ToLower()}.svg";
            item.RelatedItems.Flag = "https://flagcdn.com/useThisCdnToGetFlags";
        }
        base.ModifyItemBeforeReturning(item);
    }

    public Country GetByName(string name)
    {
        var country = Get(i => i.Name.ToLower() == name.ToLower());
        if (country == null)
        {
            throw new ClientException($"No country named {name} is found");
        }
        return country;
    }

    public Country GetFromCache(Guid guid)
    {
        if (CountriesByGuid.ContainsKey(guid))
        {
            return CountriesByGuid[guid];
        }
        return null;
    }

    public Country GetByIsoTwoLetterCode(string isoTwoLetterCode)
    {
        var country = Get(i => i.IsoTwoLetterCode.ToLower() == isoTwoLetterCode.ToLower());
        if (country == null)
        {
            throw new ClientException($"No country with IsoTwoLetterCode '{isoTwoLetterCode}' is found");
        }
        return country;
    }
}
