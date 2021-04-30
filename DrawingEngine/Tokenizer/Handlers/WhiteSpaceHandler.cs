using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingEngine.Tokenizer.Handlers
{
    public class WhiteSpaceHandler : Tokenizable
    {
        public override bool tokenizable(Tokenizer t)
        {
            char currentCharacter = t.input.peek();
            return Char.IsWhiteSpace(currentCharacter);
        }

        static bool IsSpace(Input input)
        {
            char currentCharacter = input.peek();
            return Char.IsWhiteSpace(currentCharacter);
        }

        public override Token tokenize(Tokenizer t)
        {
            Token token = new Token(t.input.Position, t.input.LineNumber,
                TokenType.Whitespace, "");
            InputCondition[] i = { IsSpace };
            foreach (var conditon in i)
            {
                token.Value += t.input.loop(conditon);
            }

            return token;
        }
    }
}
