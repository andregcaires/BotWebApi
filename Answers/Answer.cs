namespace BotWebApi.Answers
{
    public static class Answer
    {
        public static string intent(string intent){

            string resposta = "";

            switch(intent){
                case "Desenvolvedor":{
                    // pode não haver case, retornar Hero Card?
                    break;
                }
                case "Sobre":{
                    resposta = "Sou um chatbot simples de portfolio. Me pergunte mais sobre mim ou sobre meu desenvolvedor!";
                    break;
                }
                case "Saudacao":{
                    resposta = "Olá, espero que esteja bem! Converse comigo sobre mim ou sobre meu desenvolvedor!";
                    break;
                }
                case "Linguagem":{
                    resposta = "Fui desenvolvido na linguagem C#, com auxílio da Bot Framework durante a Maratona Bots da Microsoft!";
                    break;
                }
                default:{
                    resposta = "Desculpe, não entendi o que você disse! Lembre-se: sou um simples bot de porfólio!";
                    break;
                }
            }
            return resposta;
        }
    }
}