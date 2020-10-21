using System;

namespace WebApp.Core.Abstract
{
    /// <summary>
    /// Loglama sistemine erişim sağlar.
    /// </summary>
    public interface ILoggingService
    {
        /// <summary>
        /// Hata mesajını ve oluşan hata nesnesinide loglamak için kullanılır.
        /// </summary>
        /// <param name="methodName">Hata durumunun bulunduğu metot ismi</param>
        /// <param name="message">Log mesajı</param>
        /// <param name="ex">Exception tipinde oluşan hata</param>
        void LogError(string methodName, string message, Exception ex);

        /// <summary>
        /// Hata mesajını loglamak için kullanılır.
        /// </summary>
        /// <param name="methodName">Hata durumunun bulunduğu metot ismi</param>
        /// <param name="message">Log mesajı</param>
        void LogError(string methodName, string message);

        /// <summary>
        /// Uyarı mesajını loglamak için kullanılır.
        /// </summary>
        /// <param name="methodName">Uyarı durumunun bulunduğu metot ismi</param>
        /// <param name="message">Log mesajı</param>
        void LogWarn(string methodName, string message);

        /// <summary>
        /// Bilgi mesajını loglamak için kullanılır.
        /// </summary>
        /// <param name="methodName">Bilgi durumunun bulunduğu metot ismi</param>
        /// <param name="message">Log mesajı</param>
        void LogInfo(string methodName, string message);

        /// <summary>
        /// Ayırt edici bilgi mesajını loglamak için kullanılır.
        /// </summary>
        /// <param name="methodName">Bilgi durumunun bulunduğu metot ismi</param>
        /// <param name="message">Log mesajı</param>
        void LogDebug(string methodName, string message);

        /// <summary>
        /// Fonksiyon başlangıç ve bitiş bilgi mesajını loglamak için kullanılır.
        /// </summary>
        /// <param name="methodName">Bilgi durumunun bulunduğu metot ismi</param>
        /// <param name="message">Log mesajı</param>
        void LogTrace(string methodName, string message);
    }
}