using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace SiteAeroFatec.Pages
{
    public class IndexModel : PageModel
    {
        public List<Membro> EquipeCompleta { get; set; } = new List<Membro>();

        public void OnGet()
        {
            // 1. --- INSTITUCIONAL & ORIENTAÇÃO ---
            EquipeCompleta.Add(new Membro
            {
                Nome = "Nome do Diretor",
                Cargo = "Diretor da Faculdade",
                Setor = "Institucional & Orientação"
            });

            EquipeCompleta.Add(new Membro
            {
                Nome = "Nome do Coordenador",
                Cargo = "Coordenador do Curso",
                Setor = "Institucional & Orientação"
            });

            EquipeCompleta.Add(new Membro
            {
                Nome = "Nome do Professor",
                Cargo = "Professor Orientador",
                Setor = "Institucional & Orientação"
            });

            // 2. --- GESTÃO & MARKETING ---
            EquipeCompleta.Add(new Membro
            {
                Nome = "Lorena Fialho Garcia",
                Cargo = "Capitã",
                Setor = "Gestão & Marketing",
                Foto = "image/equipe/lorena.jpeg",
                LinkLinkedIn = "https://www.linkedin.com/in/lorena-fialho-124174307?utm_source=share&utm_campaign=share_via&utm_content=profile&utm_medium=android_app",
                LinkCurriculo = "Curriculos/curriculo_lorena.pdf"
            });

            EquipeCompleta.Add(new Membro
            {
                Nome = "Lislie",
                Cargo = "Social Media",
                Setor = "Gestão & Marketing",
                Foto = "image/equipe/lislie.jpeg",
                LinkLinkedIn = "https://www.linkedin.com/in/lisli%C3%AA-mendes-843b08381?utm_source=share&utm_campaign=share_via&utm_content=profile&utm_medium=ios_app",
                LinkCurriculo = "Curriculos/lislie.pdf"
            });

            EquipeCompleta.Add(new Membro
            {
                Nome = "Nome do Responsável",
                Cargo = "Financeiro",
                Setor = "Gestão & Marketing"
            });

            // 3. --- MECÂNICA DE VOO & SIMULAÇÃO ---
            EquipeCompleta.Add(new Membro
            {
                Nome = "Arthur",
                Cargo = "Diretor",
                Setor = "Mecânica de Voo & Simulação"
            });

            EquipeCompleta.Add(new Membro
            {
                Nome = "Vinicius Souza",
                Cargo = "Projetista 1",
                Setor = "Mecânica de Voo & Simulação",
                Foto = "image/equipe/ViniciusMec.jpeg",
                LinkLinkedIn = "https://www.linkedin.com/in/vinicius-de-souza-concei%C3%A7%C3%A3o-53a798379/",
                LinkCurriculo = "Curriculos/curriculoViniMec.pdf"
            });

            EquipeCompleta.Add(new Membro
            {
                Nome = "Guilherme Feltrin",
                Cargo = "Projetista 2",
                Setor = "Mecânica de Voo & Simulação",
                Foto = "image/equipe/guilhermefeltrin.jpeg",
                LinkLinkedIn = "https://www.linkedin.com/in/guilherme-feltrin-cappellini-9966a7346/",
                LinkCurriculo = "Curriculos/guilhermefeltrin.pdf"
            });

            EquipeCompleta.Add(new Membro
            {
                Nome = "Savio",
                Cargo = "Mecânico 1",
                Setor = "Mecânica de Voo & Simulação"
            });

            EquipeCompleta.Add(new Membro
            {
                Nome = "Marcio Vitor",
                Cargo = "Mecânico 2",
                Setor = "Mecânica de Voo & Simulação"
            });

            // 4. --- ELETRÔNICA & HARDWARE ---
            EquipeCompleta.Add(new Membro
            {
                Nome = "Wenderson Peruna",
                Cargo = "Diretor",
                Setor = "Eletrônica & Hardware",
                Foto = "image/equipe/wenderson.jpeg",
                LinkLinkedIn = "https://www.linkedin.com/in/wenderson-peruna-13a38819b?utm_source=share_via&utm_content=profile&utm_medium=member_android",
                LinkCurriculo = "Curriculos/wenderson.pdf"
            });

            EquipeCompleta.Add(new Membro
            {
                Nome = "Ariel Felipe",
                Cargo = "Técnico Eletrônica 1",
                Setor = "Eletrônica & Hardware"
            });

            EquipeCompleta.Add(new Membro
            {
                Nome = "Lucas Carvalho",
                Cargo = "Técnico Eletrônica 2",
                Setor = "Eletrônica & Hardware",
                Foto = "",
                LinkCurriculo = ""
            });

            // 5. --- VISÃO COMPUTACIONAL ---
            EquipeCompleta.Add(new Membro
            {
                Nome = "Gustavo",
                Cargo = "Pesquisador 1",
                Setor = "Visão Computacional",
                Foto = "image/equipe/gustavolider.jpeg",
                LinkLinkedIn = "https://www.linkedin.com/in/lucas-mendon%C3%A7a-a1096322a?utm_source=share_via&utm_content=profile&utm_medium=member_android",
                LinkCurriculo = "Curriculos/CurriculoGustavo.pdf"
            });

            EquipeCompleta.Add(new Membro
            {
                Nome = "Davy",
                Cargo = "Pesquisador 2",
                Setor = "Visão Computacional"
            });

            EquipeCompleta.Add(new Membro
            {
                Nome = "Gian",
                Cargo = "Pesquisador 3",
                Setor = "Visão Computacional"
            });

            // 6. --- FIRMWARE & EMBARCADOS ---
            EquipeCompleta.Add(new Membro
            {
                Nome = "Gustavo Alves",
                Cargo = "Diretor",
                Setor = "Firmware & Embarcados",
                Foto = "image/equipe/gustavolider.jpeg",
                LinkLinkedIn = "https://www.linkedin.com/in/lucas-mendon%C3%A7a-a1096322a?utm_source=share_via&utm_content=profile&utm_medium=member_android",
                LinkCurriculo = "Curriculos/CurriculoGustavo.pdf"
            });

            EquipeCompleta.Add(new Membro
            {
                Nome = "Lucas M.",
                Cargo = "Analista de Embarcados",
                Setor = "Firmware & Embarcados",
                Foto = "image/equipe/lucasmendonca.jpeg",
                LinkLinkedIn = "https://www.linkedin.com/in/lucas-mendon%C3%A7a-a1096322a?utm_source=share_via&utm_content=profile&utm_medium=member_android",
                LinkCurriculo = "Curriculos/CVLucasMendonca.pdf"
            });

            EquipeCompleta.Add(new Membro
            {
                Nome = "Hugo Montoro Marques",
                Cargo = "Analista de Firmware",
                Setor = "Firmware & Embarcados",
                Foto = "image/equipe/HugoMontoro.jpeg",
                LinkLinkedIn = "http://linkedin.com/in/hugo-montoro-671867179",
                LinkCurriculo = "Curriculos/HugoMontoroMarques_CV2026.pdf",
                LinkGithub = "https://github.com/hugomontoro1"
            });

            // 7. --- SOFTWARE ---
            EquipeCompleta.Add(new Membro
            {
                Nome = "Fernando Coelho",
                Cargo = "Diretor",
                Setor = "Software",
                Foto = "img/Banner.png",
                LinkLinkedIn = "https://www.linkedin.com/in/fernando-coelho-a8834733a",
                LinkGithub = "https://github.com/Fer161024"
            });

            EquipeCompleta.Add(new Membro
            {
                Nome = "Brayan Nunes",
                Cargo = "Dev",
                Setor = "Software",
                LinkLinkedIn = "https://www.linkedin.com/in/brayannunes/",
                LinkGithub = "https://github.com/nunesxfx"
            });

            EquipeCompleta.Add(new Membro
            {
                Nome = "Hugo",
                Cargo = "Dev",
                Setor = "Software",
                Foto = "image/equipe/HugoMontoro.jpeg",
                LinkCurriculo = "Curriculos/HugoMontoroMarques_CV2026.pdf",
                LinkGithub = "https://github.com/hugomontoro1",
                LinkLinkedIn = "http://linkedin.com/in/hugo-montoro-671867179"
            });
        }
    }

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