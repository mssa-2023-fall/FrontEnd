using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Caching.Distributed;
using System;
using System.Text;

public class CookiePageModel : PageModel
{
    private readonly IDistributedCache _cache;

    public CookiePageModel(IDistributedCache cache)
    {
        _cache = cache;
    }

    public void OnPost()
    {
        // Store a value in a cookie
        string valueToStore = "GlizzyGalore"; // Replace with the value you want to store
        byte[] bytesToStore = System.Text.Encoding.UTF8.GetBytes(valueToStore);
        var options = new DistributedCacheEntryOptions
        {
            AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(10) // Set the cookie expiration time
        };
        _cache.Set("GlizzyCookie", bytesToStore, options);
        string decode = Encoding.UTF8.GetString(bytesToStore);
        Console.WriteLine(_cache.Get("GlizzyCookie"));
        Console.WriteLine(decode);
    }
}

/*
 * 
 * byte[] byteArray = ...; // Your byte array
string result;

// Decode using UTF-8 encoding (common for text data)
result = Encoding.UTF8.GetString(byteArray);

// Decode using UTF-16 encoding (common for Unicode text data)
result = Encoding.Unicode.GetString(byteArray);

// Decode using ASCII encoding (for 7-bit character data)
result = Encoding.ASCII.GetString(byteArray);
*/