using FevalAWSSecretsManager.Helpers;
using FevalAWSSecretsManager.Models;
using Newtonsoft.Json;

Console.WriteLine("App Secrets Manager");
string miSecreto = await HelperSecretsManager.GetSecretAsync();
Console.WriteLine(miSecreto);

//En este lenguaje, además de leer los datos como STRING, 
//podemos convertirlos a clases Model para que sea más sencillo
KeysModel model = JsonConvert.DeserializeObject<KeysModel>(miSecreto);
//YA PODEMOS PINTAR/UTILIZAR EL DATO QUE DESEEMOS
Console.WriteLine("Ganador de la Champions: " + model.Champions);
