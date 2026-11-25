using System;
using System.Collections.Generic;

namespace LibraryLib
{
    /// <summary>
    /// Класс, реализующий функционал Городской библиотеки г. Чита
    /// </summary>
    public class LibraryFunctions
    {
        // Данные о библиотеке (по ТЗ)
        private string libraryName = "Городская библиотека г. Чита";
        private string chiefLibrarian = "Иванова Мария Петровна";

        // Список сотрудников (по ТЗ)
        private List<string> staffList = new List<string>()
        {
            "Петров П.С.",
            "Сидорова А.В.",
            "Козлов И.Д.",
            "Иванова М.П."
        };

        /// <summary>
        /// Метод 1. Возвращает ФИО главного библиотекаря.
        /// </summary>
        public string GetChiefLibrarian()
        {
            return chiefLibrarian;
        }

        /// <summary>
        /// Метод 2. Возвращает название библиотеки.
        /// </summary>
        public string GetLibraryName()
        {
            return libraryName;
        }

        /// <summary>
        /// Метод 3. Изменяет ФИО главного библиотекаря, только если он есть в списке сотрудников.
        /// </summary>
        public bool SetChiefLibrarian(string fullname)
        {
            // Проверяем, есть ли такое ФИО в списке сотрудников
            if (staffList.Contains(fullname))
            {
                chiefLibrarian = fullname;
                return true; // Успешно изменено
            }
            return false; // Не найден в списке сотрудников
        }

        /// <summary>
        /// Метод 4. Формирует код книги вида CAT_number.
        /// </summary>
        public string GenerateBookCode(string category, int number)
        {
            // Формируем строку в заданном формате
            return $"{category}_{number}";
        }

        /// <summary>
        /// Метод 5. Возвращает список сотрудников библиотеки.
        /// </summary>
        public List<string> GetStaff()
        {
            return staffList;
        }

        /// <summary>
        /// Метод 6. Добавляет нового сотрудника в список.
        /// </summary>
        public void AddStaff(string fullname)
        {
            // Добавляем сотрудника, если его еще нет в списке
            if (!staffList.Contains(fullname))
            {
                staffList.Add(fullname);
            }
        }
    }
}