using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace SiteAeroFatec.Pages
{
    public class IndexModel : PageModel
    {
        public List<Membro> EquipeCompleta { get; set; } = new List<Membro>();

        public void OnGet()
        {
            // 1. --- INSTITUCIONAL E ORIENTAÇÃO ---
            EquipeCompleta.Add(new Membro { Nome = "Nome do Diretor", Cargo = "Diretor da Faculdade", Setor = "Institucional & Orientação" });
            EquipeCompleta.Add(new Membro { Nome = "Nome do Coordenador", Cargo = "Coordenador do Curso", Setor = "Institucional & Orientação" });
            EquipeCompleta.Add(new Membro { Nome = "Nome do Professor", Cargo = "Professor Orientador", Setor = "Institucional & Orientação" });

            // 2. --- GESTÃO E MARKETING ---
            EquipeCompleta.Add(new Membro { Nome = "Lorena / Lislie", Cargo = "Capitão", Setor = "Gestão & Marketing" });
            EquipeCompleta.Add(new Membro { Nome = "Lislie / Lorena", Cargo = "Social Media", Setor = "Gestão & Marketing" });
            EquipeCompleta.Add(new Membro { Nome = "Quem doar mais dinheiro", Cargo = "Financeiro", Setor = "Gestão & Marketing" });

            // 3. --- MECÂNICA DE VOO E SIMULAÇÃO --- (Aqui está a sua super equipe de 5 pessoas junta!)
            EquipeCompleta.Add(new Membro { Nome = "Arthur", Cargo = "Diretor", Setor = "Mecânica de Voo & Simulação" });
            EquipeCompleta.Add(new Membro { Nome = "Vinicius Souza", Cargo = "Projetista 1", Setor = "Mecânica de Voo & Simulação", LinkLinkedIn = "https://www.linkedin.com/in/vinicius-de-souza-concei%C3%A7%C3%A3o-53a798379/" });
            EquipeCompleta.Add(new Membro { Nome = "Guilherme Feltrin", Cargo = "Projetista 2", Setor = "Mecânica de Voo & Simulação", LinkLinkedIn = "https://www.linkedin.com/in/guilherme-feltrin-cappellini-9966a7346/" });
            EquipeCompleta.Add(new Membro { Nome = "Savio", Cargo = "Mecânico 1", Setor = "Mecânica de Voo & Simulação" });
            EquipeCompleta.Add(new Membro { Nome = "Marcio Vitor", Cargo = "Mecânico 2", Setor = "Mecânica de Voo & Simulação" });

            // 4. --- ELETRÔNICA E HARDWARE ---
            EquipeCompleta.Add(new Membro { Nome = "Wanderson", Cargo = "Diretor", Setor = "Eletrônica & Hardware" });
            EquipeCompleta.Add(new Membro { Nome = "Ariel Felipe", Cargo = "Técnico Eletrônica 1", Setor = "Eletrônica & Hardware" });
            EquipeCompleta.Add(new Membro { Nome = "Lucas Carvalho", Cargo = "Técnico Eletrônica 2", Setor = "Eletrônica & Hardware" });

            // 5. --- VISÃO COMPUTACIONAL ---
            EquipeCompleta.Add(new Membro { Nome = "Gustavo", Cargo = "Pesquisador 1", Setor = "Visão Computacional" });
            EquipeCompleta.Add(new Membro { Nome = "Davy", Cargo = "Pesquisador 2", Setor = "Visão Computacional" });
            EquipeCompleta.Add(new Membro { Nome = "Gian", Cargo = "Pesquisador 3", Setor = "Visão Computacional" });

            // 6. --- FIRMWARE E EMBARCADOS ---
            EquipeCompleta.Add(new Membro { Nome = "Gustavo Alves", Cargo = "Diretor", Setor = "Firmware & Embarcados" });
            EquipeCompleta.Add(new Membro { Nome = "Lucas M", Cargo = "Analista de Embarcados", Setor = "Firmware & Embarcados" });
            EquipeCompleta.Add(new Membro { Nome = "Hugo", Cargo = "Analista de Firmware", Setor = "Firmware & Embarcados" });

            // 7. --- SOFTWARE ---
            EquipeCompleta.Add(new Membro { Nome = "Fernando Coelho", Cargo = "Diretor", Setor = "Software", Foto = "abc.jpg", LinkLinkedIn = "https://www.linkedin.com/in/fernando-coelho-a8834733a", LinkGithub = "https://github.com/Fer161024" });
            EquipeCompleta.Add(new Membro { Nome = "Brayan Nunes", Cargo = "Dev", Setor = "Software", LinkLinkedIn = "https://www.linkedin.com/in/brayannunes/", LinkGithub = "https://github.com/nunesxfx" });
            EquipeCompleta.Add(new Membro { Nome = "Hugo", Cargo = "Dev", Setor = "Software" });
        }
    }

    // A "Planta" do Membro com os 3 links padrão
    public class Membro
    {
        public string? Nome { get; set; }
        public string? Cargo { get; set; }
        public string? Setor { get; set; }
        public string? Foto { get; set; } = "img/Banner.png";
        public string? LinkLinkedIn { get; set; } = "#";
        public string? LinkGithub { get; set; } = "#";
        public string? LinkCurriculo { get; set; } = "#";
    }
}