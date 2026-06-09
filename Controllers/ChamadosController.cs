using Microsoft.AspNetCore.Mvc;
using ZeladoriaUrbana.Application.DTOs.Requests;
using ZeladoriaUrbana.Application.Services.Chamados;

namespace ZeladoriaUrbana.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ChamadosController : ControllerBase
{
    private readonly CreateChamadoService _service;

    public ChamadosController(
        CreateChamadoService service
    )
    {
        _service = service;
    }

    [HttpPost]
    public async Task<IActionResult> Criar(
        [FromBody] CreateChamadoRequest request
    )
    {
        var result = await _service.ExecuteAsync(request);

        return Ok(result);
    }
}