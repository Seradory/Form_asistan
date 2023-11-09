using OpenAI_API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenAI_API.Completions;
using OpenAI_API.Models;
using System.Threading;

namespace Form_asistan
{
    public class gpt_api
    {
        string apiKey = "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"; // API anahtarınızı buraya ekleyin.
        OpenAI_API.Chat.Conversation conversation;



        public gpt_api()
        {
            OpenAIAPI api = new OpenAIAPI(apiKey);
            conversation = api.Chat.CreateConversation();
        }

        public void kısıt_gir() { }
        public void kısıt_gir(string kısıt)
        {
            //örnek chat.AppendSystemMessage("Sana söylediğim sayıları çarpmanı istiyorum. Sadece çarpımın sonuçlarını yaz. Örneğin 15 5 dediğimde 75 diye cevaplayacaksın.");
            // // give a few examples as user and assistant
            //// chat.AppendUserInput("1 2");
            //// chat.AppendExampleChatbotOutput("2");
            // //chat.AppendUserInput("Is this an animal? House");
            //// chat.AppendExampleChatbotOutput("No");
            if (kısıt != string.Empty)
            {
                conversation.AppendSystemMessage(kısıt);
            }
            else
            {
                kısıt_gir();
            }

        }

        public void kısıt_gir(string kısıt, string ornek_input, string ornek_cevap)
        {
            //örnek chat.AppendSystemMessage("Sana söylediğim sayıları çarpmanı istiyorum. Sadece çarpımın sonuçlarını yaz. Örneğin 15 5 dediğimde 75 diye cevaplayacaksın.");
            // // give a few examples as user and assistant
            //// chat.AppendUserInput("1 2");
            //// chat.AppendExampleChatbotOutput("2");
            // //chat.AppendUserInput("Is this an animal? House");
            //// chat.AppendExampleChatbotOutput("No");

            conversation.AppendSystemMessage(kısıt);
            conversation.AppendUserInput(ornek_input);
            conversation.AppendExampleChatbotOutput(ornek_cevap);
        }

        public void kısıt_gir(string kısıt, string ornek_input, string ornek_cevap, string ornek_input2, string ornek_cevap2)
        {
            //örnek chat.AppendSystemMessage("Sana söylediğim sayıları çarpmanı istiyorum. Sadece çarpımın sonuçlarını yaz. Örneğin 15 5 dediğimde 75 diye cevaplayacaksın.");
            // // give a few examples as user and assistant
            //// chat.AppendUserInput("1 2");
            //// chat.AppendExampleChatbotOutput("2");
            // //chat.AppendUserInput("Is this an animal? House");
            //// chat.AppendExampleChatbotOutput("No");

            conversation.AppendSystemMessage(kısıt);
            conversation.AppendUserInput(ornek_input);
            conversation.AppendExampleChatbotOutput(ornek_cevap);
            conversation.AppendUserInput(ornek_input2);
            conversation.AppendExampleChatbotOutput(ornek_cevap2);
        }

        public void kısıt_gir(string kısıt, string ornek_input, string ornek_cevap, string ornek_input2, string ornek_cevap2, string ornek_input3, string ornek_cevap3)
        {
            //örnek chat.AppendSystemMessage("Sana söylediğim sayıları çarpmanı istiyorum. Sadece çarpımın sonuçlarını yaz. Örneğin 15 5 dediğimde 75 diye cevaplayacaksın.");
            // // give a few examples as user and assistant
            //// chat.AppendUserInput("1 2");
            //// chat.AppendExampleChatbotOutput("2");
            // //chat.AppendUserInput("Is this an animal? House");
            //// chat.AppendExampleChatbotOutput("No");

            conversation.AppendSystemMessage(kısıt);
            conversation.AppendUserInput(ornek_input);
            conversation.AppendExampleChatbotOutput(ornek_cevap);
            conversation.AppendUserInput(ornek_input2);
            conversation.AppendExampleChatbotOutput(ornek_cevap2);
            conversation.AppendUserInput(ornek_input3);
            conversation.AppendExampleChatbotOutput(ornek_cevap3);
        }


        public async Task<string> soru_sor_cevap_alAsync(string soru, bool log)
        {

            conversation.AppendUserInput(soru);
            string response = await conversation.GetResponseFromChatbotAsync();
            if (log)
            {
                Console.WriteLine("\nGelen Cevap : " + response + "\n");
            }

            return response;
        }




    }
}
