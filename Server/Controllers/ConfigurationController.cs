using BlazorEComm.Shared.Dtos;
using BlazorEComm.Shared.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BlazorEComm.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ConfigurationController : ControllerBase
{
    private readonly IConfigurationService _configurationService;

    public ConfigurationController(IConfigurationService configurationService)
    {
        _configurationService = configurationService;
    }

    [HttpPost("admin"), Authorize(Roles = "Admin")]
    public async Task<ActionResult<ServiceResponse<List<ConfigurationDto>>>> AddConfiguration(ConfigurationDto configuration, CancellationToken cancellationToken) =>
        Ok(await _configurationService.AddConfiguration(configuration, cancellationToken));

    [HttpDelete("admin/{configurationKey}/{configurationLanguage}"), Authorize(Roles = "Admin")]
    public async Task<ActionResult<ServiceResponse<List<ConfigurationDto>>>> DeleteConfiguration(string configurationKey, string configurationLanguage, CancellationToken cancellationToken) =>
        Ok(await _configurationService.DeleteConfiguration(configurationKey, configurationLanguage, cancellationToken));
    
    [HttpGet("admin/{configurationKey}/{configurationLanguage}"), Authorize(Roles = "Admin")]
    public async Task<ActionResult<ServiceResponse<string>>> GetConfigurationValue(string configurationKey, string configurationLanguage, CancellationToken cancellationToken) =>
      Ok(await _configurationService.GetConfigurationValue(configurationKey, configurationLanguage, cancellationToken));

    [HttpGet("admin/Configuration/{configurationKey}/{configurationLanguage}"), Authorize(Roles = "Admin")]
    public async Task<ActionResult<ServiceResponse<Configuration?>>> GetConfigurations(string configurationKey, string configurationLanguage, CancellationToken cancellationToken) =>
        Ok(await _configurationService.GetConfiguration(configurationKey, configurationLanguage, cancellationToken));

    [HttpGet]
    public async Task<ActionResult<ServiceResponse<List<ConfigurationDto>>>> GetConfigurations(CancellationToken cancellationToken) =>
        Ok(await _configurationService.GetConfigurations(cancellationToken));

    [HttpPut("admin"), Authorize(Roles = "Admin")]
    public async Task<ActionResult<ServiceResponse<List<ConfigurationDto>>>> UpdateConfiguration(ConfigurationDto configuration, CancellationToken cancellationToken) =>
        Ok(await _configurationService.UpdateConfiguration(configuration, cancellationToken));
}