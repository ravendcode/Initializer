using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Initializer.Services
{
    public static class LangService
    {
        public static string Lang { get; set; }
        private static Dictionary<string, string> Translations { get; set; } = new Dictionary<string, string>()
        {
            ["en.success"] = "Successfully completed!",
            ["ru.success"] = "Успешно выполнено!",
            ["en.choose_folder"] = "Choose a folder!",
            ["ru.choose_folder"] = "Выберите папку!",
            ["en.no_file_error"] = "No file",
            ["ru.no_file_error"] = "Нету файла",
            ["en.invalid_error"] = "Invalid",
            ["ru.invalid_error"] = "Невалидный",
            ["en.select_folder_btn"] = "Select folder",
            ["ru.select_folder_btn"] = "Выбрать папку",
            ["en.open_in_explorer"] = "Open in explorer",
            ["ru.open_in_explorer"] = "Открыть в проводнике",
            ["en.create_btn"] = "Create",
            ["ru.create_btn"] = "Создать",
            ["en.add_project_name_folder"] = "Add folder with project name",
            ["ru.add_project_name_folder"] = "Добавить папку с названием проекта"
        };

        public static string Translate(string key)
        {
            return Translations[Lang.ToLower() + "." + key.ToLower()];
        }
    }
}
