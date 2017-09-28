using HCRUDEasy.Domain.Bank;
using HCRUDEasy.Domain.Person;
using HCRUDEasy.Domain.Person.Attributes.Work.Information;
using HCRUDEasy.Domain.Person.Attributes.Work.Skill;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HCRUDEasy.Web.ViewsModels
{
    public class CandidateViewModel
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string City { get; set; }
        public string State { get; set; }

        public int BankInformationId { get; set; }
        public string BankInformationPersonName { get; set; }
        public string BankInformationCpf { get; set; }
        public string BankInformationBankName { get; set; }
        public string BankInformationAgency { get; set; }
        public string BankInformationAccountType { get; set; }
        public string BankInformationAccountNumber { get; set; }
     


        public string Skype { get; set; }
        public string Linkedin { get; set; }
        public string PortFolio { get; set; }
        public string WorkDisponibility { get; set; }
        public string WorkSchedule { get; set; }
        public string Salary { get; set; }
        public string PaymentType { get; set; }




        public IEnumerable<CandidateViewModel> Candidates { get; set; }
    }
}
