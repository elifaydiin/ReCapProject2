﻿using Business.Constans;
using Castle.DynamicProxy;
using Core.Extension;
using Core.Utilities.Interceptors;
using Core.Utilities.IoC;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;


namespace Business.BusinessAspects.Autofac
{
    public class SecuredOperation : MethodInterception //aspects
    {
        private string[] _roles;
        private IHttpContextAccessor _httpContextAccessor; // her kişi için bir(istek) httpcontext oluşur bir interface olarak gelir bize.

        public SecuredOperation(string roles)
        {
            _roles = roles.Split(',');
            _httpContextAccessor = ServiceTool.ServiceProvider.GetService<IHttpContextAccessor>();

        }

        protected override void OnBefore(IInvocation invocation)
        {
            var roleClaims = _httpContextAccessor.HttpContext.User.ClaimRoles();
            foreach (var role in _roles)
            {
                if (roleClaims.Contains(role))
                {
                    return;
                }
            }
            throw new Exception(Messages.AuthorizationDenied);
        }
    }
}
