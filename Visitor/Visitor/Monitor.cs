﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
	public class Monitor : IComputerPart
	{
		public void Accept(IComputerPartVisitor computerPartVisitor)
		{
			computerPartVisitor.visit(this);
		}
	}
}
