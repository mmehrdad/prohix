using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Api.Controllers.Subjects
{
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class SubjectController : Controller
    {
    }
}