﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    public class Material
    {
        public string name;
        public double count;
        public int place;
    }
}
