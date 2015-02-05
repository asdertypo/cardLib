using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch10CardLib
{
    public class Cards:CollectionBase
    {
        public void Add(Card newCard) {
            List.Add(newCard);
        }
        public void Remove(Card oldCard) {
            List.Remove(oldCard);
        }
        public Card this[int cardIndex] {
            get { return (Card)List[cardIndex]; }
            set { List[cardIndex] = value; }
        }
        public void CopyTo(Cards targetCards) {
            for (int i = 0; i < this.Count; i++) {
                targetCards[i] = this[i];
            }
        }
        public void CopyToEmpty(Cards targetCards) {
            for (int i = 0; i < this.Count; i++) {
                targetCards.Add(this[i]);
            }
        }
        public bool Contains(Card card) {
            return InnerList.Contains(card);
        }
    }
}
