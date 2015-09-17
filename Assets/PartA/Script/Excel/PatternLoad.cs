using UnityEngine;
using System;
using System.IO;
using System.Collections;
using NPOI.HSSF.UserModel;
using NPOI.XSSF.UserModel;
using NPOI.SS.UserModel;

public class PatternLoad : MonoBehaviour {
	//private string path = "Assets/PartA/Excel/patternlist.xlsx";
	private Manager manager;
	private int[,,] loadpattern;

	// Use this for initialization
	void Awake(){
		manager = GameObject.Find("Manager").GetComponent<Manager>();

		//using (FileStream fs = new FileStream(path,FileMode.Open,FileAccess.Read)
		using (FileStream fs = Resources.Load("patternlist")as ((typeof)FileStream)) //new FileStream(path,FileMode.Open,FileAccess.Read)
		{
			ReadExcelPattern(new XSSFWorkbook(fs));
		}
		manager.patternlist = loadpattern;
	}

	void ReadExcelPattern(IWorkbook workbook){
		int sheetnumber = workbook.NumberOfSheets;
		loadpattern = new int[sheetnumber,8,5];
		for(int sheetindex = 0;sheetindex < sheetnumber;++sheetindex){
			ISheet _isheet = workbook.GetSheetAt(sheetindex);
			int lastrownum = _isheet.LastRowNum;
			for(int rowindex = _isheet.FirstRowNum;rowindex <= lastrownum;++rowindex){
				IRow row = _isheet.GetRow(rowindex);
				if(row == null)continue;
				for(int cellindex = row.FirstCellNum;cellindex < lastrownum;++cellindex){
					ICell cell = row.GetCell(cellindex);
					if(cell != null)
						loadpattern[sheetindex,rowindex,cellindex] = Convert.ToInt32(cell.ToString());
				}
			}	
		}
	}
}