﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeenCompiler.Compiler.Nodes {
    public class AbstractFunctionCallNode : ActionNode {

        public override void accept(Virtual_Machine.NodeVisitor visitor)
        {
            //visitor.visit(this);
        }
    }
}
