using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Task03
{
	// Класс для хранения списка вопросов. А также для сериализации в XML и десериализации из XML
	class TrueFalse
	{
		string fileName;
		List<Question> list;
		public string FileName
		{
			get { return fileName; }
			set { fileName = value; }
		}
		public TrueFalse(string fileName)
		{
			this.fileName = fileName;
			list = new List<Question>();
		}
		public void Add(string text, bool trueFalse)
		{
			list.Add(new Question(text, trueFalse));
		}
		public void Remove(int index)
		{
			if (list != null && index < list.Count && index >= 0) list.RemoveAt(index);
		}
		// Индексатор - свойство для доступа к закрытому объекту
		public Question this[int index]
		{
			get { return list[index]; }
		}
		public void Save()
		{
			XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Question>));
			Stream fStream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
			xmlFormat.Serialize(fStream, list);
			fStream.Close();
		}
		public void Load()
		{
			XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Question>));
			Stream fStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
			list = (List<Question>)xmlFormat.Deserialize(fStream);
			fStream.Close();
		}
		public int Count
		{
			get { return list.Count; }
		}
	}


	/*
	/// <summary>
	/// Класс для хранения объекта вопроса
	/// </summary>
	[Serializable]
	public class Question
	{
		private string _text;
		private bool _amswer;
		public Question() { }
		public Question(string QuestionText, bool Answer)
		{
			_text = QuestionText;
			_amswer = Answer;
		}
		public string QuestionText { get { return _text; } }
		public bool CorrectAnswer { get { return _amswer; } }
	}

	public class ListQuestion
	{
		string _fileName;
		List<Question> _list;
		public ListQuestion(string FileName)
		{
			_fileName = FileName;
			_list = new List<Question>();
		}
		public string FileName { get { return _fileName; } set { _fileName = value; } }
		public void Add(string QuestionText, bool CorrectAnswer)
		{ _list.Add(new Question(QuestionText, CorrectAnswer)); }
		public bool Remove(int Index)
		{
			bool res = false;
			if (_list != null && Index < _list.Count && Index >= 0)
			{
				res = true;
				_list.RemoveAt(Index);
			}
			return res;
		}
		public Question this[int Index] { get { return _list[Index]; } }
		public int Count { get { return _list.Count; } }
		public void Load()
		{
			XmlSerializer xmlSer = new XmlSerializer(typeof(List<Question>));
			Stream fs = new FileStream(_fileName, FileMode.Open, FileAccess.Read);
			_list = (List<Question>)xmlSer.Deserialize(fs);
			fs.Close();
		}
		public bool Save()
		{
			bool res = false;
			XmlSerializer xmlSer = new XmlSerializer(typeof(List<Question>));
			try
			{
				using (Stream fs = new FileStream(_fileName, FileMode.Create, FileAccess.Write))
				{
					xmlSer.Serialize(fs, _list);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"При сохранении БД возникла ошибка\n{ex.Message}", "Ошибка сохранения БД", MessageBoxButtons.OK, MessageBoxIcon.Error);
				res = false;
			}
			return res;
		}
		*/


}
