﻿using Microsoft.AspNetCore.Components;

namespace FitnessDiary.Pages.Autenticacao;

public partial class Login : ComponentBase
{
    #region Properties
    //public LoginRequest InputRequest { get; set; } = new();
    public bool ShowErrors { get; set; } = false;
    public bool Autenticando { get; set; } = false;
    public string Error { get; set; } = "";


    #endregion

    #region Services
    //[Inject]
    //public IAuthService AuthService { get; set; } = null!;

    [Inject]
    public NavigationManager NavigationManager { get; set; } = null!;

    #endregion

    #region Methods
    public async Task OnValidSubmitAsync()
    {
        try
        {
            if (ValidarDados())
            {
                //var result = await AuthService.Login(InputRequest);

                //if (result is not null && result.Token is not null)
                //{
                //    ExibirMensagem("Login efetuado com sucesso.", Severity.Success);
                //    NavigationManager.NavigateTo("/");
                //}
                //else
                //    ExibirMensagem("Usuário e/ou senha inválidos.");
            }
        }
        catch (Exception ex)
        {
            ExibirMensagem($"Não foi possível fazer o Login : {ex.Message}");
        }
    }

    private bool ValidarDados()
    {
        //if (string.IsNullOrWhiteSpace(InputRequest.Usuario) || string.IsNullOrWhiteSpace(InputRequest.Senha))
        //{
        //    ExibirMensagem("Usuário e/ou senha inválidos.");
        //    return false;
        //}
        return true;
    }

    private void ExibirMensagem(string mensagem)
    {

    }


    #endregion
}
