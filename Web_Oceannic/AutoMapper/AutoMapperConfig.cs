using AutoMapper;
using Domain.Models;
using OceannicAPI.Models;

namespace Web_Oceannic.AutoMapper
{
    public class AutoMapperConfig : Profile
    { 
        public AutoMapperConfig()
        {
            CreateMap<User, UserViewModel>().ReverseMap();
            CreateMap<ImgUser, ImgUserViewModel>().ReverseMap();
            CreateMap<Bank, BankViewModel>().ReverseMap();
            CreateMap<Currency, CurrencyViewModel>().ReverseMap();
            CreateMap<Deposit, DepositViewModel>().ReverseMap();
            CreateMap<Wallet, WalletViewModel>().ReverseMap();
            CreateMap<UserBanks, UserBanksViewModel>().ReverseMap();
            CreateMap<Transfer, TransferViewModel>().ReverseMap();
        }
    }
}
