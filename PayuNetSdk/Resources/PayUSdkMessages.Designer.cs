﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.18052
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PayuNetSdk.Resources {
    using System;
    
    
    /// <summary>
    ///   Clase de recurso fuertemente tipado, para buscar cadenas traducidas, etc.
    /// </summary>
    // StronglyTypedResourceBuilder generó automáticamente esta clase
    // a través de una herramienta como ResGen o Visual Studio.
    // Para agregar o quitar un miembro, edite el archivo .ResX y, a continuación, vuelva a ejecutar ResGen
    // con la opción /str o recompile su proyecto de VS.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class PayUSdkMessages {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal PayUSdkMessages() {
        }
        
        /// <summary>
        ///   Devuelve la instancia de ResourceManager almacenada en caché utilizada por esta clase.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("PayuNetSdk.Resources.PayUSdkMessages", typeof(PayUSdkMessages).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Reemplaza la propiedad CurrentUICulture del subproceso actual para todas las
        ///   búsquedas de recursos mediante esta clase de recurso fuertemente tipado.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a The enum parameter [{0}] is null..
        /// </summary>
        internal static string EnumIsNull {
            get {
                return ResourceManager.GetString("EnumIsNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Error type: {0}. Description: {1} - Error list: {2}.
        /// </summary>
        internal static string FormatErrorSdkException {
            get {
                return ResourceManager.GetString("FormatErrorSdkException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a The parameter [{0}] isn&apos;t a valid bool value..
        /// </summary>
        internal static string InvalidBool {
            get {
                return ResourceManager.GetString("InvalidBool", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a The parameter [{0}] isn&apos;t a valid date value..
        /// </summary>
        internal static string InvalidDate {
            get {
                return ResourceManager.GetString("InvalidDate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a The parameter [{0}] isn&apos;t a valid decimal value..
        /// </summary>
        internal static string InvalidDecimal {
            get {
                return ResourceManager.GetString("InvalidDecimal", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a The parameter [{0}] isn&apos;t a valid enum value..
        /// </summary>
        internal static string InvalidEnum {
            get {
                return ResourceManager.GetString("InvalidEnum", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a The parameter [{0}] isn&apos;t a valid integer value..
        /// </summary>
        internal static string InvalidInteger {
            get {
                return ResourceManager.GetString("InvalidInteger", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a [{0}] parameter has error: {1}..
        /// </summary>
        internal static string PropertyErrorFromApi {
            get {
                return ResourceManager.GetString("PropertyErrorFromApi", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a [{0}] can not be null or empty..
        /// </summary>
        internal static string RequiredParameter {
            get {
                return ResourceManager.GetString("RequiredParameter", resourceCulture);
            }
        }
    }
}
