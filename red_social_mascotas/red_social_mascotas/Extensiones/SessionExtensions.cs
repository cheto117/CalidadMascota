﻿using Microsoft.AspNetCore.Http;
using System.Text.Json;
namespace red_social_mascotas.Extensiones
{
    public static class SessionExtensions
    {
        public static void Set<T>(this ISession session, string key, T value)
        {
            session.SetString(key, JsonSerializer.Serialize(value));
        }

        public static T Get<T>(this ISession session, string key)
        {
            var value = session.GetString(key);
            return JsonSerializer.Deserialize<T>(value);
        }
    }
}
