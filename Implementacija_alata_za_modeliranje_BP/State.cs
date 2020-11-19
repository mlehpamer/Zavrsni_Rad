using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementacija_alata_za_modeliranje_BP
{
    public class State
    {
		private int x;
		private int y;
		public int getX()
		{
			return x;
		}
		public void setX(int x)
		{
			this.x = x;
		}
		public int getY()
		{
			return y;
		}
		public void setY(int y)
		{
			this.y = y;
		}
		public State(int x, int y)
		{
			this.x = x;
			this.y = y;
		}

		
		public override bool Equals(Object obj)
		{
				State other = (State)obj;
				if (this.x == other.x && this.y == other.y) return true;
				return false;
		}
	}
}
