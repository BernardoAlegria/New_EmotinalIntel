using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace New_EmotionalIntel.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the New_EmotionalIntelUser class
    public class New_EmotionalIntelUser : IdentityUser
    {
        //Aqui pode-se adicionar parâmetros à classe que representa os utilizadores ou fazer override aos herdados
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }


        //Adicionar também as chaves fk que estavam dantes na tabela de users que existia?
    }
}
