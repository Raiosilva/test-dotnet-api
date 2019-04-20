using System;
using System.Collections.Generic;
using UsersApi.Models;

namespace UsersApi.Repositories
{
    public interface IFundoCapitalRepository
    {
        void Adicionar(FundoCapital fundo);
        void Alterar(FundoCapital fundo);
        IEnumerable<FundoCapital> ListarFundo();
        FundoCapital ObterPorId(Guid id);
        void RemoverFundo(FundoCapital fundo);
    }
}