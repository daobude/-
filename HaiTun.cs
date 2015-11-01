using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeagueSharp;
using LeagueSharp.Common;
using SharpDX;

namespace LSharp海豚防封 {
	class Program {

		public static Menu Config;

		static void Main(string[] args) {
			Config = new Menu("海豚防封：防封状态启动中","LSHARPSET",true);
			Config.AddItem(new MenuItem("海豚", "官网:Www.Haoll.Cn"));
			Config.AddToMainMenu();
			Game.OnUpdate += Game_OnUpdate;
		}

		private static void Game_OnUpdate(EventArgs args) {
			Hacks.DisableDrawings = false;
        }
	}
}
