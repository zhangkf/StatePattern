﻿using System.Drawing;

namespace StatePattern
{
    class RectangleMouse : AbstractMouseState
    {
        public override void OnMouseClick(Mouse mouse, Point location)
        {
            switch (mouse._drawerState)
            {
                case DrawerState.WaitRectangleBeginPoint:
                    mouse._begin = location;
                    mouse._drawerState = DrawerState.WaitRectangleEndPoint;
                    break;

                case DrawerState.WaitRectangleEndPoint:
                    mouse._end = location;
                    mouse._drawerState = DrawerState.None;
                    mouse._shape = new Rectangle(mouse._begin, mouse._end);
                    _waitForClick = false;
                    break;
            }
        }
    }
}