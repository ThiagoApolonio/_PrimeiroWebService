using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace _PrimeiroWebService.Common
{
    /// <summary>
    /// Model genérico com os campos criados a partir de um SELECT
    /// </summary>
    public class ModelosGenericos
    {
        /// <summary>
        /// Campos e valores
        /// A classe genérica Dictionary<TKey,TValue> também implementa a interface genérica IDictionary<TKey,TValue>. Portanto, cada elemento nessas coleções é um par chave-valor.</param>
        /// <returns></returns>
        public Dictionary<String, object> keys { get; set; }


        /// <summary>
        /// Retorna tipo do campo
        /// </summary>
        /// <param name="NomeCampo">Nome do campo</param>
        /// <returns></returns>
        public object PegarValorCampo(string NomeCampo)
        {
            return this.keys[NomeCampo]; //This. retorna o valor das instancias atuais
        }

        /// <summary>
        /// Retorna tipo do campo
        /// </summary>
        /// <param name="NomeCampo">Nome do campo</param>
        /// <returns></returns>
        public Type PegarTipoCampo(string NomeCampo)
        {
            return this.keys[NomeCampo].GetType();
        }


    }
}