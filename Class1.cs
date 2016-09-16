using System;
using System.Threading;

namespace is2WakeUpDBCon
{
	/// <summary>
	/// [is2WakeUpDBCon]
	/// </summary>
	//--------------------------------------------------------------------------
	// �C������
	//--------------------------------------------------------------------------
	// ADD 2008.01.31 ���s�j���� �T�[�r�X�̒ǉ� 
	//--------------------------------------------------------------------------
	// MOD 2010.05.14 ���s�j���� ���Ԓ��� 
	//--------------------------------------------------------------------------
	// MOD 2011.02.25 ���s�j���� ���q�Ή� 
	// MOD 2011.09.27 ���s�j���� �G�R�[�����l�Ή� 
	//--------------------------------------------------------------------------
	class Class1
	{
		private static System.Threading.Mutex mutex;

		// �v�����T�[�r�X�ϐ�
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
// ADD 2008.01.31 ���s�j���� �T�[�r�X�̒ǉ� START
		private static is2oshirase.Service1 sv_oshirase = null;
// ADD 2008.01.31 ���s�j���� �T�[�r�X�̒ǉ� END
// MOD 2011.02.25 ���s�j���� ���q�Ή� START
		private static is2oji.Service1      sv_oji      = null;
// MOD 2011.02.25 ���s�j���� ���q�Ή� END
// MOD 2011.09.27 ���s�j���� �G�R�[�����l�Ή� START
		private static is2EXDBGET.Service1  sv_EXDBGET  = null;
		private static is2EXsyukka.Service1 sv_EXsyukka = null;
// MOD 2011.09.27 ���s�j���� �G�R�[�����l�Ή� END
// MOD 2010.05.14 ���s�j���� ���Ԓ��� START
		private static is2logout.Service1   sv_logout   = null;
// MOD 2010.05.14 ���s�j���� ���Ԓ��� END
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
// ADD 2008.01.31 ���s�j���� �T�[�r�X�̒ǉ� START
											 , "is2oshirase"
// ADD 2008.01.31 ���s�j���� �T�[�r�X�̒ǉ� END
// MOD 2011.02.25 ���s�j���� ���q�Ή� START
											 , "is2oji     "
// MOD 2011.02.25 ���s�j���� ���q�Ή� END
// MOD 2011.09.27 ���s�j���� �G�R�[�����l�Ή� START
											 , "is2EXDBGET "
											 , "is2EXsyukka"
// MOD 2011.09.27 ���s�j���� �G�R�[�����l�Ή� END
										   };
//		private static int iInterval = 5 * 60 * 1000; // 5���Ԋu
// MOD 2010.05.14 ���s�j���� ���Ԓ��� START
//		private static int iInterval = 60 * 60 * 1000; // 60���Ԋu
		private static int iInterval = 30;	// 30���Ԋu
		private static int iInitCon  = 3;	// �c�a�����ڑ���
// MOD 2010.05.14 ���s�j���� ���Ԓ��� END

		/// <summary>
		/// �A�v���P�[�V�����̃��C�� �G���g�� �|�C���g�ł��B
		/// </summary>
		[STAThread]
		static void Main(string[] args)
		{
			// �A�v���P�[�V�����̓�d�N���h�~
			mutex = new System.Threading.Mutex(false, "is2WakeUpDBCon");
			if( mutex.WaitOne(0, false) == false) return;

// MOD 2010.06.01 ���s�j���� ���Ԓ��� START
			try{
				�ڑ��e�X�g();
			}finally{
				// �~���[�e�b�N�X�̔j��
				mutex.Close();
			}
		}

		static void �ڑ��e�X�g()
		{
// MOD 2010.06.01 ���s�j���� ���Ԓ��� END
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
// ADD 2008.01.31 ���s�j���� �T�[�r�X�̒ǉ� START
			if(sv_oshirase == null) sv_oshirase = new is2oshirase.Service1();
// ADD 2008.01.31 ���s�j���� �T�[�r�X�̒ǉ� END
// MOD 2011.02.25 ���s�j���� ���q�Ή� START
			if(sv_oji      == null) sv_oji      = new is2oji.Service1();
// MOD 2011.02.25 ���s�j���� ���q�Ή� END
// MOD 2011.09.27 ���s�j���� �G�R�[�����l�Ή� START
			if(sv_EXDBGET  == null) sv_EXDBGET  = new is2EXDBGET.Service1();
			if(sv_EXsyukka == null) sv_EXsyukka = new is2EXsyukka.Service1();
// MOD 2011.09.27 ���s�j���� �G�R�[�����l�Ή� END
// MOD 2010.05.14 ���s�j���� ���Ԓ��� START
			if(sv_logout   == null) sv_logout   = new is2logout.Service1();
// MOD 2010.05.14 ���s�j���� ���Ԓ��� END

// MOD 2010.05.14 ���s�j���� ���Ԓ��� START
//			while(true)
//			{
//				Console.WriteLine("�m�F�����F" + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"));
//				for(int iCnt = 0; iCnt < sService.Length; iCnt++)
//				{
//					checkService( iCnt );
//				}
//				Thread.Sleep(iInterval);
//			}
//
//			// �~���[�e�b�N�X�̔j��
//			mutex.Close();
// MOD 2010.05.14 ���s�j���� ���Ԓ��� END

// MOD 2010.06.01 ���s�j���� ���Ԓ��� START
			string sServer = Environment.MachineName.ToUpper();
			if(DateTime.Now.Hour == 4){
				if(sServer == "IS2AP01"){
					;
				}else if(sServer == "IS2AP02"){
					Thread.Sleep(300000); // �@�T����
				}else if(sServer == "IS2AP03"){
					Thread.Sleep(600000); // �P�O����
				}else if(sServer == "IS2AP04"){
					Thread.Sleep(900000); // �P�T����
				}else{
					;
				}
			}
// MOD 2010.06.01 ���s�j���� ���Ԓ��� END

			//����ڑ��m�F
			LogOut("����m�F�F" + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"));
			for(int iCnt = 0; iCnt < sService.Length; iCnt++){
// MOD 2010.05.14 ���s�j���� ���Ԓ��� START
//				checkService( iCnt );
				checkService( iCnt, sServer );
// MOD 2010.05.14 ���s�j���� ���Ԓ��� END
			}

			DateTime dtNow = DateTime.Now;
			DateTime dt�J�n����
				= new DateTime(dtNow.Year, dtNow.Month, dtNow.Day, dtNow.Hour, 0, 0);
			DateTime dt�I������	// �����̂R���T�T���i�ċN�����Ԃ̑O�܂Łj
//				= new DateTime(dtNow.Year, dtNow.Month, dtNow.Day, 7, 50, 0).AddDays(1);
// MOD 2010.06.01 ���s�j���� ���Ԓ��� START
//				= new DateTime(dtNow.Year, dtNow.Month, dtNow.Day, 3, 50, 0).AddDays(1);
				= new DateTime(dtNow.Year, dtNow.Month, dtNow.Day, 3, 55, 0).AddDays(1);
// MOD 2010.06.01 ���s�j���� ���Ԓ��� END
			// �J�n�����̐ݒ�
			if(dtNow.Minute >= 30){
				dt�J�n���� = dt�J�n����.AddMinutes(60);
			}else{
				dt�J�n���� = dt�J�n����.AddMinutes(30);
			}
			// �T�[�o���ƂɊJ�n���������炷
// MOD 2010.06.01 ���s�j���� ���Ԓ��� START
//			string sServer = Environment.MachineName;
// MOD 2010.06.01 ���s�j���� ���Ԓ��� END

			if(sServer == "IS2AP01"){
				dt�J�n���� = dt�J�n����.AddMinutes(5);
			}else if(sServer == "IS2AP02"){
				dt�J�n���� = dt�J�n����.AddMinutes(10);
			}else if(sServer == "IS2AP03"){
				dt�J�n���� = dt�J�n����.AddMinutes(15);
			}else if(sServer == "IS2AP04"){
				dt�J�n���� = dt�J�n����.AddMinutes(20);
			}else{
				dt�J�n���� = dt�J�n����.AddMinutes(5);
			}
			LogOut("�J�n�\��F" + dt�J�n����.ToString("yyyy/MM/dd HH:mm:ss"));
			LogOut("�I���\��F" + dt�I������.ToString("yyyy/MM/dd HH:mm:ss"));

			while(DateTime.Now.CompareTo(dt�I������) < 0){
				// �J�n�����҂�
//				for(int iCnt = 0; iCnt < iInterval; iCnt++){
				for(int iCnt = 0; iCnt < 60; iCnt++){
					if(DateTime.Now.CompareTo(dt�I������) > 0) break; // �I�������`�F�b�N
					if(DateTime.Now.CompareTo(dt�J�n����) > 0) break; // �J�n�����`�F�b�N
					Console.Write(".");
					Thread.Sleep(60000); // �P����
				}
				if(DateTime.Now.CompareTo(dt�I������) > 0) break; // �I�������`�F�b�N

				LogOut("�m�F�����F" + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"));
				// �e�T�[�r�X�ւ̐ڑ��e�X�g
				for(int iCnt = 0; iCnt < sService.Length; iCnt++){
					if(DateTime.Now.CompareTo(dt�I������) > 0) break; // �I�������`�F�b�N
// MOD 2010.05.14 ���s�j���� ���Ԓ��� START
//					checkService( iCnt );
					checkService( iCnt, sServer );
// MOD 2010.05.14 ���s�j���� ���Ԓ��� END
				}
				Console.WriteLine("");
				if(DateTime.Now.CompareTo(dt�I������) > 0) break; // �I�������`�F�b�N
//				// ���ԑ҂�
//				for(int iCnt = 0; iCnt < iInterval; iCnt++){
//					if(DateTime.Now.CompareTo(dt�I������) > 0) break; // �I�������`�F�b�N
//					Thread.Sleep(60000); // �P����
//					Console.Write(".");
//				}
//				Console.WriteLine("");
				dt�J�n���� = dt�J�n����.AddMinutes(iInterval);
				//�������x��āA�I���������x�ꂽ�ꍇ�A�X�ɉ��Z����
				while(DateTime.Now.CompareTo(dt�J�n����) > 0){
					dt�J�n���� = dt�J�n����.AddMinutes(iInterval);
				}
			}
			LogOut("�I�������F" + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"));
// MOD 2010.05.14 ���s�j���� ���Ԓ��� END
		}
		/*
		 * 
		 */
// MOD 2010.05.14 ���s�j���� ���Ԓ��� START
//		static private void checkService(int iIdx)
		static private void checkService(int iIdx, string sServer)
// MOD 2010.05.14 ���s�j���� ���Ԓ��� END
		{
			try
			{
//				Console.WriteLine(sService[iIdx] + "�F" + "�ڑ����D�D�D");
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
// ADD 2008.01.31 ���s�j���� �T�[�r�X�̒ǉ� START
					case 10:
						sRet = sv_oshirase.wakeupDB2(iInitCon);
						break;
// ADD 2008.01.31 ���s�j���� �T�[�r�X�̒ǉ� END
// MOD 2011.02.25 ���s�j���� ���q�Ή� START
					case 11:
						sRet = sv_oji.wakeupDB2(iInitCon);
						break;
// MOD 2011.02.25 ���s�j���� ���q�Ή� END
// MOD 2011.09.27 ���s�j���� �G�R�[�����l�Ή� START
					case 12:
						if(sServer == "IS2AP02" || sServer == "IS2" || sServer == "IS2DV01"){
							sRet = sv_EXDBGET.wakeupDB2(iInitCon);
						}else{
							sRet = "�p�X";
						}
						break;
					case 13:
						if(sServer == "IS2AP02" || sServer == "IS2" || sServer == "IS2DV01"){
							sRet = sv_EXsyukka.wakeupDB2(iInitCon);
						}else{
							sRet = "�p�X";
						}
						break;
// MOD 2011.09.27 ���s�j���� �G�R�[�����l�Ή� END
				}
				if(sRet.Length == 0)
					Console.WriteLine(sService[iIdx] + "�F" + "�ғ����D�D�D");
				else
					Console.WriteLine(sService[iIdx] + "�F" + sRet);
			}
			catch(Exception ex)
			{
				Console.WriteLine(sService[iIdx] + "�F" + ex.Message);
			}
		}
// MOD 2010.05.14 ���s�j���� ���Ԓ��� START
		/*
		 * 
		 */
		static private void LogOut(string sLog)
		{
			Console.WriteLine(sLog+"\n");

			System.Text.StringBuilder sbBuff = new System.Text.StringBuilder(2048);
			// ����
			sbBuff.Append("["+ System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff") +"]");
			// �h�o�A�h���X
			sbBuff.Append("[-]");
			// �[���h�c
			sbBuff.Append("[-]");
			// ����b�c
			sbBuff.Append("[-]");
			// ���p�҂b�c
			sbBuff.Append("[-]");
			// �o�[�W�����Ǘ�
			sbBuff.Append("[-]");
			// �A�v���P�[�V�����p�X
			sbBuff.Append("[-]");
			sbBuff.Append(sLog);
// MOD 2011.09.27 ���s�j���� �G�R�[�����l�Ή� START
//			sv_logout.LogOut(sbBuff.ToString());
			try{
				sv_logout.LogOut(sbBuff.ToString());
			}catch(Exception ex){
				Console.WriteLine("[LogOut]" + ex.Message);
			}
// MOD 2011.09.27 ���s�j���� �G�R�[�����l�Ή� END
		}
// MOD 2010.05.14 ���s�j���� ���Ԓ��� END
	}
}
