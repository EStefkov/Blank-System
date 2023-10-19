using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace BLANKMenu.Models
{


    /*
    Интерфейсът "IUserRepository" дефинира контракт за работа с потребители в системата. Този интерфейс предоставя методи и операции,
    които могат да бъдат използвани за управление на потребителските акаунти. Класовете, които имплементират този интерфейс,
    трябва да осигурят конкретна логика за аутентикация, добавяне, премахване, редакция и извличане на информация за потребители.
    */
    public interface IUserRepository
    {
        bool AuthenticateUser(NetworkCredential credential);
        /*
        Проверява валидността на потребителския акаунт, като се изисква предоставяне на мрежови идентификационни данни (потребителско име и парола).
        Връща "true", ако потребителят е успешно аутентициран, и "false" в противен случай.
        */

        void Add(UserModel userModel);
        
        void Remove(int id);
        void Edit(UserModel userModel);
        UserModel GetById(int id);
        UserModel GetByUsername(string username);
        IEnumerable<UserModel> GetByAll();
        
        
        object GetByUsername(IPrincipal? currentPrincipal);
    }
}
