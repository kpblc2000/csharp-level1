using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Task03
{
	// Класс для хранения списка вопросов. А также для сериализации в XML и десериализации из XML
	class TrueFalse
	{
		string _fileName;
		List<Question> list;

		/// <summary>
		/// Имя файла БД
		/// </summary>
		public string FileName
		{
			get { return _fileName; }
			set { _fileName = value; }
		}

		public TrueFalse(string fileName)
		{
			_fileName = fileName;
			list = new List<Question>();
		}

		/// <summary>
		/// Добавление нового вопроса в базу
		/// </summary>
		/// <param name="text">Текст вопроса</param>
		/// <param name="trueFalse">Правда или нет</param>
		public void Add(string text, bool trueFalse)
		{
			list.Add(new Question(text, trueFalse));
		}

		/// <summary>
		/// Удаление элемента из базы по индексу
		/// </summary>
		/// <param name="index">Индекс элемента для удаления</param>
		public void Remove(int index)
		{
			if (list != null && index < list.Count && index >= 0) list.RemoveAt(index);
		}

		// Индексатор - свойство для доступа к закрытому объекту
		public Question this[int index]
		{
			get { return list[index]; }
		}

		/// <summary>
		/// Сохранение БД в файл по умолчанию (имя файла определено в конструкторе или при выполнении SaveAs)
		/// </summary>
		public void Save()
		{
			XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Question>));
			Stream fStream = new FileStream(_fileName, FileMode.Create, FileAccess.Write);
			xmlFormat.Serialize(fStream, list);
			fStream.Close();
		}

		/// <summary>
		/// Сохранение БД в другой файл и назначение этого файла как файлы БД
		/// </summary>
		/// <param name="FileName">Имя файла для сохранения</param>
		public void SaveAs(string FileName)
		{
			XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Question>));
			Stream fStream = new FileStream(FileName, FileMode.Create, FileAccess.Write);
			xmlFormat.Serialize(fStream, list);
			fStream.Close();
			_fileName = FileName;
		}

		/// <summary>
		/// Загрузка из БД (имя файла определено в конструкторе или при выполнении SaveAs)
		/// </summary>
		public void Load()
		{
			XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Question>));
			Stream fStream = new FileStream(_fileName, FileMode.Open, FileAccess.Read);
			list = (List<Question>)xmlFormat.Deserialize(fStream);
			fStream.Close();
		}

		/// <summary>
		/// Количество элементов в базе
		/// </summary>
		public int Count
		{
			get { return list.Count; }
		}

		
	}
}
