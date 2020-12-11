using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace CleanArchitecture.WebApi.Middlewares
{
    public class AuthMiddleware
    {
        private readonly RequestDelegate _next;

        public AuthMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var token = context.Request.Query["access_token"];

            if (string.IsNullOrEmpty(context.Request.Headers["Authorization"]) && !string.IsNullOrEmpty(token))
            {
                context.Request.Headers["Authorization"] = $"Bearer {token}";
            }
            await _next(context);
        }
    }
}