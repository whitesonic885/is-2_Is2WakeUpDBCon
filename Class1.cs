using System;
using System.Threading;

namespace is2WakeUpDBCon
{
	/// <summary>
	/// [is2WakeUpDBCon]
	/// </summary>
	//--------------------------------------------------------------------------
	// 修正履歴
	//--------------------------------------------------------------------------
	// ADD 2008.01.31 東都）高木 サービスの追加 
	//--------------------------------------------------------------------------
	// MOD 2010.05.14 東都）高木 時間調整 
	//--------------------------------------------------------------------------
	// MOD 2011.02.25 東都）高木 王子対応 
	// MOD 2011.09.27 東都）高木 エコー金属様対応 
	//--------------------------------------------------------------------------
	class Class1
	{
		private static System.Threading.Mutex mutex;

		// Ｗｅｂサービス変数
		private static is2address.Service1  sv_address  = null;
		private static is2goirai.Service1   sv_goirai   = null;
		private static is2hinagata.Service1 sv_hinagata = null;
		private static is2init.Service1     sv_init     = null;
		private static is2kiji.Service1     sv_kiji     = null;
		private static is2Mainte.Service1   sv_Mainte   = null;
		private static is2otodoke.Service1  sv_otodoke  = null;
		private static is2print.Service1    sv_print    = null;
		private static is2syukka.Service1   sv_syukka   = null;
		private static is2seikyuu.Service1  sv_seikyuu  = null;
// ADD 2008.01.31 東都）高木 サービスの追加 START
		private static is2oshirase.Service1 sv_oshirase = null;
// ADD 2008.01.31 東都）高木 サービスの追加 END
// MOD 2011.02.25 東都）高木 王子対応 START
		private static is2oji.Service1      sv_oji      = null;
// MOD 2011.02.25 東都）高木 王子対応 END
// MOD 2011.09.27 東都）高木 エコー金属様対応 START
		private static is2EXDBGET.Service1  sv_EXDBGET  = null;
		private static is2EXsyukka.Service1 sv_EXsyukka = null;
// MOD 2011.09.27 東都）高木 エコー金属様対応 END
// MOD 2010.05.14 東都）高木 時間調整 START
		private static is2logout.Service1   sv_logout   = null;
// MOD 2010.05.14 東都）高木 時間調整 END
		private static string[] sService = {
											   "is2address ",
											   "is2goirai  ",
											   "is2hinagata",
											   "is2init    ",
											   "is2kiji    ",
											   "is2Mainte  ",
											   "is2otodoke ",
											   "is2print   ",
											   "is2syukka  ",
											   "is2seikyuu "
// ADD 2008.01.31 東都）高木 サービスの追加 START
											 , "is2oshirase"
// ADD 2008.01.31 東都）高木 サービスの追加 END
// MOD 2011.02.25 東都）高木 王子対応 START
											 , "is2oji     "
// MOD 2011.02.25 東都）高木 王子対応 END
// MOD 2011.09.27 東都）高木 エコー金属様対応 START
											 , "is2EXDBGET "
											 , "is2EXsyukka"
// MOD 2011.09.27 東都）高木 エコー金属様対応 END
										   };
//		private static int iInterval = 5 * 60 * 1000; // 5分間隔
// MOD 2010.05.14 東都）高木 時間調整 START
//		private static int iInterval = 60 * 60 * 1000; // 60分間隔
		private static int iInterval = 30;	// 30分間隔
		private static int iInitCon  = 3;	// ＤＢ初期接続数
// MOD 2010.05.14 東都）高木 時間調整 END

		/// <summary>
		/// アプリケーションのメイン エントリ ポイントです。
		/// </summary>
		[STAThread]
		static void Main(string[] args)
		{
			// アプリケーションの二重起動防止
			mutex = new System.Threading.Mutex(false, "is2WakeUpDBCon");
			if( mutex.WaitOne(0, false) == false) return;

// MOD 2010.06.01 東都）高木 時間調整 START
			try{
				接続テスト();
			}finally{
				// ミューテックスの破棄
				mutex.Close();
			}
		}

		static void 接続テスト()
		{
// MOD 2010.06.01 東都）高木 時間調整 END
			if(sv_address  == null) sv_address  = new is2address.Service1();
			if(sv_goirai   == null) sv_goirai   = new is2goirai.Service1();
			if(sv_hinagata == null) sv_hinagata = new is2hinagata.Service1();
			if(sv_init     == null) sv_init     = new is2init.Service1();
			if(sv_kiji     == null) sv_kiji     = new is2kiji.Service1();
			if(sv_Mainte   == null) sv_Mainte   = new is2Mainte.Service1();
			if(sv_otodoke  == null) sv_otodoke  = new is2otodoke.Service1();
			if(sv_print    == null) sv_print    = new is2print.Service1();
			if(sv_syukka   == null) sv_syukka   = new is2syukka.Service1();
			if(sv_seikyuu  == null) sv_seikyuu  = new is2seikyuu.Service1();
// ADD 2008.01.31 東都）高木 サービスの追加 START
			if(sv_oshirase == null) sv_oshirase = new is2oshirase.Service1();
// ADD 2008.01.31 東都）高木 サービスの追加 END
// MOD 2011.02.25 東都）高木 王子対応 START
			if(sv_oji      == null) sv_oji      = new is2oji.Service1();
// MOD 2011.02.25 東都）高木 王子対応 END
// MOD 2011.09.27 東都）高木 エコー金属様対応 START
			if(sv_EXDBGET  == null) sv_EXDBGET  = new is2EXDBGET.Service1();
			if(sv_EXsyukka == null) sv_EXsyukka = new is2EXsyukka.Service1();
// MOD 2011.09.27 東都）高木 エコー金属様対応 END
// MOD 2010.05.14 東都）高木 時間調整 START
			if(sv_logout   == null) sv_logout   = new is2logout.Service1();
// MOD 2010.05.14 東都）高木 時間調整 END

// MOD 2010.05.14 東都）高木 時間調整 START
//			while(true)
//			{
//				Console.WriteLine("確認日時：" + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"));
//				for(int iCnt = 0; iCnt < sService.Length; iCnt++)
//				{
//					checkService( iCnt );
//				}
//				Thread.Sleep(iInterval);
//			}
//
//			// ミューテックスの破棄
//			mutex.Close();
// MOD 2010.05.14 東都）高木 時間調整 END

// MOD 2010.06.01 東都）高木 時間調整 START
			string sServer = Environment.MachineName.ToUpper();
			if(DateTime.Now.Hour == 4){
				if(sServer == "IS2AP01"){
					;
				}else if(sServer == "IS2AP02"){
					Thread.Sleep(300000); // 　５分間
				}else if(sServer == "IS2AP03"){
					Thread.Sleep(600000); // １０分間
				}else if(sServer == "IS2AP04"){
					Thread.Sleep(900000); // １５分間
				}else{
					;
				}
			}
// MOD 2010.06.01 東都）高木 時間調整 END

			//初回接続確認
			LogOut("初回確認：" + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"));
			for(int iCnt = 0; iCnt < sService.Length; iCnt++){
// MOD 2010.05.14 東都）高木 時間調整 START
//				checkService( iCnt );
				checkService( iCnt, sServer );
// MOD 2010.05.14 東都）高木 時間調整 END
			}

			DateTime dtNow = DateTime.Now;
			DateTime dt開始日時
				= new DateTime(dtNow.Year, dtNow.Month, dtNow.Day, dtNow.Hour, 0, 0);
			DateTime dt終了日時	// 翌日の３時５５分（再起動時間の前まで）
//				= new DateTime(dtNow.Year, dtNow.Month, dtNow.Day, 7, 50, 0).AddDays(1);
// MOD 2010.06.01 東都）高木 時間調整 START
//				= new DateTime(dtNow.Year, dtNow.Month, dtNow.Day, 3, 50, 0).AddDays(1);
				= new DateTime(dtNow.Year, dtNow.Month, dtNow.Day, 3, 55, 0).AddDays(1);
// MOD 2010.06.01 東都）高木 時間調整 END
			// 開始時刻の設定
			if(dtNow.Minute >= 30){
				dt開始日時 = dt開始日時.AddMinutes(60);
			}else{
				dt開始日時 = dt開始日時.AddMinutes(30);
			}
			// サーバごとに開始時刻をずらす
// MOD 2010.06.01 東都）高木 時間調整 START
//			string sServer = Environment.MachineName;
// MOD 2010.06.01 東都）高木 時間調整 END

			if(sServer == "IS2AP01"){
				dt開始日時 = dt開始日時.AddMinutes(5);
			}else if(sServer == "IS2AP02"){
				dt開始日時 = dt開始日時.AddMinutes(10);
			}else if(sServer == "IS2AP03"){
				dt開始日時 = dt開始日時.AddMinutes(15);
			}else if(sServer == "IS2AP04"){
				dt開始日時 = dt開始日時.AddMinutes(20);
			}else{
				dt開始日時 = dt開始日時.AddMinutes(5);
			}
			LogOut("開始予定：" + dt開始日時.ToString("yyyy/MM/dd HH:mm:ss"));
			LogOut("終了予定：" + dt終了日時.ToString("yyyy/MM/dd HH:mm:ss"));

			while(DateTime.Now.CompareTo(dt終了日時) < 0){
				// 開始時刻待ち
//				for(int iCnt = 0; iCnt < iInterval; iCnt++){
				for(int iCnt = 0; iCnt < 60; iCnt++){
					if(DateTime.Now.CompareTo(dt終了日時) > 0) break; // 終了日時チェック
					if(DateTime.Now.CompareTo(dt開始日時) > 0) break; // 開始日時チェック
					Console.Write(".");
					Thread.Sleep(60000); // １分間
				}
				if(DateTime.Now.CompareTo(dt終了日時) > 0) break; // 終了日時チェック

				LogOut("確認日時：" + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"));
				// 各サービスへの接続テスト
				for(int iCnt = 0; iCnt < sService.Length; iCnt++){
					if(DateTime.Now.CompareTo(dt終了日時) > 0) break; // 終了日時チェック
// MOD 2010.05.14 東都）高木 時間調整 START
//					checkService( iCnt );
					checkService( iCnt, sServer );
// MOD 2010.05.14 東都）高木 時間調整 END
				}
				Console.WriteLine("");
				if(DateTime.Now.CompareTo(dt終了日時) > 0) break; // 終了日時チェック
//				// 時間待ち
//				for(int iCnt = 0; iCnt < iInterval; iCnt++){
//					if(DateTime.Now.CompareTo(dt終了日時) > 0) break; // 終了日時チェック
//					Thread.Sleep(60000); // １分間
//					Console.Write(".");
//				}
//				Console.WriteLine("");
				dt開始日時 = dt開始日時.AddMinutes(iInterval);
				//処理が遅れて、終了時刻が遅れた場合、更に加算する
				while(DateTime.Now.CompareTo(dt開始日時) > 0){
					dt開始日時 = dt開始日時.AddMinutes(iInterval);
				}
			}
			LogOut("終了日時：" + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"));
// MOD 2010.05.14 東都）高木 時間調整 END
		}
		/*
		 * 
		 */
// MOD 2010.05.14 東都）高木 時間調整 START
//		static private void checkService(int iIdx)
		static private void checkService(int iIdx, string sServer)
// MOD 2010.05.14 東都）高木 時間調整 END
		{
			try
			{
//				Console.WriteLine(sService[iIdx] + "：" + "接続中．．．");
				string sRet = "";
				switch(iIdx)
				{
					case 0:
						sRet = sv_address.wakeupDB2(iInitCon);
						break;
					case 1:
						sRet = sv_goirai.wakeupDB2(iInitCon);
						break;
					case 2:
						sRet = sv_hinagata.wakeupDB2(iInitCon);
						break;
					case 3:
						sRet = sv_init.wakeupDB2(iInitCon);
						break;
					case 4:
						sRet = sv_kiji.wakeupDB2(iInitCon);
						break;
					case 5:
						sRet = sv_Mainte.wakeupDB2(iInitCon);
						break;
					case 6:
						sRet = sv_otodoke.wakeupDB2(iInitCon);
						break;
					case 7:
						sRet = sv_print.wakeupDB2(iInitCon);
						break;
					case 8:
						sRet = sv_syukka.wakeupDB2(iInitCon);
						break;
					case 9:
						sRet = sv_seikyuu.wakeupDB2(iInitCon);
						break;
// ADD 2008.01.31 東都）高木 サービスの追加 START
					case 10:
						sRet = sv_oshirase.wakeupDB2(iInitCon);
						break;
// ADD 2008.01.31 東都）高木 サービスの追加 END
// MOD 2011.02.25 東都）高木 王子対応 START
					case 11:
						sRet = sv_oji.wakeupDB2(iInitCon);
						break;
// MOD 2011.02.25 東都）高木 王子対応 END
// MOD 2011.09.27 東都）高木 エコー金属様対応 START
					case 12:
						if(sServer == "IS2AP02" || sServer == "IS2" || sServer == "IS2DV01"){
							sRet = sv_EXDBGET.wakeupDB2(iInitCon);
						}else{
							sRet = "パス";
						}
						break;
					case 13:
						if(sServer == "IS2AP02" || sServer == "IS2" || sServer == "IS2DV01"){
							sRet = sv_EXsyukka.wakeupDB2(iInitCon);
						}else{
							sRet = "パス";
						}
						break;
// MOD 2011.09.27 東都）高木 エコー金属様対応 END
				}
				if(sRet.Length == 0)
					Console.WriteLine(sService[iIdx] + "：" + "稼動中．．．");
				else
					Console.WriteLine(sService[iIdx] + "：" + sRet);
			}
			catch(Exception ex)
			{
				Console.WriteLine(sService[iIdx] + "：" + ex.Message);
			}
		}
// MOD 2010.05.14 東都）高木 時間調整 START
		/*
		 * 
		 */
		static private void LogOut(string sLog)
		{
			Console.WriteLine(sLog+"\n");

			System.Text.StringBuilder sbBuff = new System.Text.StringBuilder(2048);
			// 日時
			sbBuff.Append("["+ System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff") +"]");
			// ＩＰアドレス
			sbBuff.Append("[-]");
			// 端末ＩＤ
			sbBuff.Append("[-]");
			// 会員ＣＤ
			sbBuff.Append("[-]");
			// 利用者ＣＤ
			sbBuff.Append("[-]");
			// バージョン管理
			sbBuff.Append("[-]");
			// アプリケーションパス
			sbBuff.Append("[-]");
			sbBuff.Append(sLog);
// MOD 2011.09.27 東都）高木 エコー金属様対応 START
//			sv_logout.LogOut(sbBuff.ToString());
			try{
				sv_logout.LogOut(sbBuff.ToString());
			}catch(Exception ex){
				Console.WriteLine("[LogOut]" + ex.Message);
			}
// MOD 2011.09.27 東都）高木 エコー金属様対応 END
		}
// MOD 2010.05.14 東都）高木 時間調整 END
	}
}
