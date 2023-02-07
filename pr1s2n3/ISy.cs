using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

/*Вам необходимо разработать ИС «Учет материалов».
Основные задачи системы: осуществление учета поступления,
отгрузки и перемещений внутри складских материалов. На склад
поступает материал, необходимо внести информацию в систему:
наименование материала, количество, номер помещения. Затем, они
могут быть перемещены с места на место или выданы. Также в ИС
хранится информация о самом складе: список помещений и ФИО
материальных ответственных за каждое помещение.*/

namespace pr1s2n3
{
    public class ISy
    {
        public List<int> places = new List<int>();
        public List<Material> materials = new List<Material>();
        public Dictionary<int, string> FIO = new Dictionary<int, string>();

        public void Prihod(string name, double count, int place)
        {
        Material mat = new Material();
            mat.name = name;
            mat.count = count;
            mat.place = place;
            materials.Add(mat);
        }

        public void Perevoz(Material material, int nplace)
        {
            for (int i = 0; i < materials.Count; i++)
            {
                if (materials[i] == material)
                    materials[i].place = nplace;
            }
        }

        public void Vidan(Material material)
        {
            for (int i = 0; i < materials.Count; i++)
            {
                if (materials[i] == material)
                    materials.Remove(material);
            }
        }
    }
}
