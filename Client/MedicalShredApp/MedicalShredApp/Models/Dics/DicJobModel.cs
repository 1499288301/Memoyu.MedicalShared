/**************************************************************************  
*   =================================
*   CLR�汾  ��4.0.30319.42000
*   �ļ����� ��DicProvinceModel
*   =================================
*   �� �� �� ��Memoyu
*   �������� ��2020/4/13 22:26:51
*   �������� ��
*   =================================
*   �� �� �� ��
*   �޸����� ��
*   �޸����� ��
*   ================================= 
***************************************************************************/
using System;

namespace MedicalShredApp.Models.Dics
{
    public class DicJobModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int SortId { get; set; }
        public bool IsEnable { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public override string ToString() => Name;
    }
}