using AutoMapper;
using Com.Kana.Service.Auth.Lib.BusinessLogic.Interfaces;
using Com.Kana.Service.Auth.Lib.Models;
using Com.Kana.Service.Auth.Lib.Services.IdentityService;
using Com.Kana.Service.Auth.Lib.Services.ValidateService;
using Com.Kana.Service.Auth.Lib.ViewModels;
using Com.Kana.Service.Auth.WebApi.Utilities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Com.Kana.Service.Auth.WebApi.Controllers.v1
{
    [Produces("application/json")]
    [ApiVersion("1.0")]
    [Route("v{version:apiVersion}/roles")]
    [Authorize]
    public class RolesController : BaseController<Role, RoleViewModel, IRoleService>
    {
        public RolesController(IIdentityService identityService, IValidateService validateService, IRoleService service, IMapper mapper) : base(identityService, validateService, service, mapper, "1.0.0")
        {
        }
    }
}
