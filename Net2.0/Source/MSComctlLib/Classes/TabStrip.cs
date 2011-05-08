//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using LateBindingApi.Core;
namespace LateBindingApi.MSComctlLibApi
{

	#region Delegates

	#pragma warning disable
	public delegate void TabStrip_ClickEventHandler();
	public delegate void TabStrip_KeyDownEventHandler(ref Int16 KeyCode, Int16 Shift);
	public delegate void TabStrip_KeyPressEventHandler(ref Int16 KeyAscii);
	public delegate void TabStrip_KeyUpEventHandler(ref Int16 KeyCode, Int16 Shift);
	public delegate void TabStrip_MouseDownEventHandler(Int16 Button, Int16 Shift, Int32 x, Int32 y);
	public delegate void TabStrip_MouseMoveEventHandler(Int16 Button, Int16 Shift, Int32 x, Int32 y);
	public delegate void TabStrip_MouseUpEventHandler(Int16 Button, Int16 Shift, Int32 x, Int32 y);
	public delegate void TabStrip_BeforeClickEventHandler(ref Int16 Cancel);
	public delegate void TabStrip_OLEStartDragEventHandler(ref LateBindingApi.MSComctlLibApi.DataObject Data, ref Int32 AllowedEffects);
	public delegate void TabStrip_OLEGiveFeedbackEventHandler(ref Int32 Effect, ref bool DefaultCursors);
	public delegate void TabStrip_OLESetDataEventHandler(ref LateBindingApi.MSComctlLibApi.DataObject Data, ref Int16 DataFormat);
	public delegate void TabStrip_OLECompleteDragEventHandler(ref Int32 Effect);
	public delegate void TabStrip_OLEDragOverEventHandler(ref LateBindingApi.MSComctlLibApi.DataObject Data, ref Int32 Effect, ref Int16 Button, ref Int16 Shift, ref Single x, ref Single y, ref Int16 State);
	public delegate void TabStrip_OLEDragDropEventHandler(ref LateBindingApi.MSComctlLibApi.DataObject Data, ref Int32 Effect, ref Int16 Button, ref Int16 Shift, ref Single x, ref Single y);
	#pragma warning restore

	#endregion

	///<summary>
	/// CoClass TabStrip SupportByLibrary WCC6.0 
	///</summary>
	[SupportByLibrary("WCC6.0")]
	public class TabStrip : ITabStrip, IEventBinding 
	{
		#pragma warning disable
		#region Fields
		
		private NetRuntimeSystem.Runtime.InteropServices.ComTypes.IConnectionPoint _connectPoint;
		private string _activeSinkId;
		private NetRuntimeSystem.Type _thisType;
		ITabStripEvents_SinkHelper _iTabStripEvents_SinkHelper;
	
		#endregion
		
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public TabStrip(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public TabStrip(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public TabStrip(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		public TabStrip()
		{
			CreateFromProgId("MSComctlLib.TabStrip");
		}
		
		/// <param name="progId">progId</param>
		public TabStrip(string progId)
		{
			CreateFromProgId(progId);
		}

		#endregion
		
		#region Private Methods
		
		/// <summary>
        /// creates active sink helper
        /// </summary>
		private void CreateEventBridge()
        {
			if(false == LateBindingApi.Core.Settings.EnableEvents)
				return;
	
			if (null != _connectPoint)
				return;
	
            if (null == _activeSinkId)
				_activeSinkId = SinkHelper.GetConnectionPoint(this, ref _connectPoint, ITabStripEvents_SinkHelper.Id);


			if(ITabStripEvents_SinkHelper.Id.Equals(_activeSinkId, StringComparison.InvariantCultureIgnoreCase))
			{
				_iTabStripEvents_SinkHelper = new ITabStripEvents_SinkHelper(this, _connectPoint);
				return;
			} 
        }
		
		#endregion

		#region Events

		/// <summary>
		/// SupportByLibrary WCC6.0
		/// </summary>
		private event TabStrip_ClickEventHandler _ClickEvent;

		/// <summary>
		/// SupportByLibrary WCC6.0
		/// </summary>
		[SupportByLibrary("WCC6.0")]
		public event TabStrip_ClickEventHandler ClickEvent
		{
			add
			{
				CreateEventBridge();
				_ClickEvent += value;
			}
			remove
			{
				_ClickEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary WCC6.0
		/// </summary>
		private event TabStrip_KeyDownEventHandler _KeyDownEvent;

		/// <summary>
		/// SupportByLibrary WCC6.0
		/// </summary>
		[SupportByLibrary("WCC6.0")]
		public event TabStrip_KeyDownEventHandler KeyDownEvent
		{
			add
			{
				CreateEventBridge();
				_KeyDownEvent += value;
			}
			remove
			{
				_KeyDownEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary WCC6.0
		/// </summary>
		private event TabStrip_KeyPressEventHandler _KeyPressEvent;

		/// <summary>
		/// SupportByLibrary WCC6.0
		/// </summary>
		[SupportByLibrary("WCC6.0")]
		public event TabStrip_KeyPressEventHandler KeyPressEvent
		{
			add
			{
				CreateEventBridge();
				_KeyPressEvent += value;
			}
			remove
			{
				_KeyPressEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary WCC6.0
		/// </summary>
		private event TabStrip_KeyUpEventHandler _KeyUpEvent;

		/// <summary>
		/// SupportByLibrary WCC6.0
		/// </summary>
		[SupportByLibrary("WCC6.0")]
		public event TabStrip_KeyUpEventHandler KeyUpEvent
		{
			add
			{
				CreateEventBridge();
				_KeyUpEvent += value;
			}
			remove
			{
				_KeyUpEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary WCC6.0
		/// </summary>
		private event TabStrip_MouseDownEventHandler _MouseDownEvent;

		/// <summary>
		/// SupportByLibrary WCC6.0
		/// </summary>
		[SupportByLibrary("WCC6.0")]
		public event TabStrip_MouseDownEventHandler MouseDownEvent
		{
			add
			{
				CreateEventBridge();
				_MouseDownEvent += value;
			}
			remove
			{
				_MouseDownEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary WCC6.0
		/// </summary>
		private event TabStrip_MouseMoveEventHandler _MouseMoveEvent;

		/// <summary>
		/// SupportByLibrary WCC6.0
		/// </summary>
		[SupportByLibrary("WCC6.0")]
		public event TabStrip_MouseMoveEventHandler MouseMoveEvent
		{
			add
			{
				CreateEventBridge();
				_MouseMoveEvent += value;
			}
			remove
			{
				_MouseMoveEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary WCC6.0
		/// </summary>
		private event TabStrip_MouseUpEventHandler _MouseUpEvent;

		/// <summary>
		/// SupportByLibrary WCC6.0
		/// </summary>
		[SupportByLibrary("WCC6.0")]
		public event TabStrip_MouseUpEventHandler MouseUpEvent
		{
			add
			{
				CreateEventBridge();
				_MouseUpEvent += value;
			}
			remove
			{
				_MouseUpEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary WCC6.0
		/// </summary>
		private event TabStrip_BeforeClickEventHandler _BeforeClickEvent;

		/// <summary>
		/// SupportByLibrary WCC6.0
		/// </summary>
		[SupportByLibrary("WCC6.0")]
		public event TabStrip_BeforeClickEventHandler BeforeClickEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeClickEvent += value;
			}
			remove
			{
				_BeforeClickEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary WCC6.0
		/// </summary>
		private event TabStrip_OLEStartDragEventHandler _OLEStartDragEvent;

		/// <summary>
		/// SupportByLibrary WCC6.0
		/// </summary>
		[SupportByLibrary("WCC6.0")]
		public event TabStrip_OLEStartDragEventHandler OLEStartDragEvent
		{
			add
			{
				CreateEventBridge();
				_OLEStartDragEvent += value;
			}
			remove
			{
				_OLEStartDragEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary WCC6.0
		/// </summary>
		private event TabStrip_OLEGiveFeedbackEventHandler _OLEGiveFeedbackEvent;

		/// <summary>
		/// SupportByLibrary WCC6.0
		/// </summary>
		[SupportByLibrary("WCC6.0")]
		public event TabStrip_OLEGiveFeedbackEventHandler OLEGiveFeedbackEvent
		{
			add
			{
				CreateEventBridge();
				_OLEGiveFeedbackEvent += value;
			}
			remove
			{
				_OLEGiveFeedbackEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary WCC6.0
		/// </summary>
		private event TabStrip_OLESetDataEventHandler _OLESetDataEvent;

		/// <summary>
		/// SupportByLibrary WCC6.0
		/// </summary>
		[SupportByLibrary("WCC6.0")]
		public event TabStrip_OLESetDataEventHandler OLESetDataEvent
		{
			add
			{
				CreateEventBridge();
				_OLESetDataEvent += value;
			}
			remove
			{
				_OLESetDataEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary WCC6.0
		/// </summary>
		private event TabStrip_OLECompleteDragEventHandler _OLECompleteDragEvent;

		/// <summary>
		/// SupportByLibrary WCC6.0
		/// </summary>
		[SupportByLibrary("WCC6.0")]
		public event TabStrip_OLECompleteDragEventHandler OLECompleteDragEvent
		{
			add
			{
				CreateEventBridge();
				_OLECompleteDragEvent += value;
			}
			remove
			{
				_OLECompleteDragEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary WCC6.0
		/// </summary>
		private event TabStrip_OLEDragOverEventHandler _OLEDragOverEvent;

		/// <summary>
		/// SupportByLibrary WCC6.0
		/// </summary>
		[SupportByLibrary("WCC6.0")]
		public event TabStrip_OLEDragOverEventHandler OLEDragOverEvent
		{
			add
			{
				CreateEventBridge();
				_OLEDragOverEvent += value;
			}
			remove
			{
				_OLEDragOverEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary WCC6.0
		/// </summary>
		private event TabStrip_OLEDragDropEventHandler _OLEDragDropEvent;

		/// <summary>
		/// SupportByLibrary WCC6.0
		/// </summary>
		[SupportByLibrary("WCC6.0")]
		public event TabStrip_OLEDragDropEventHandler OLEDragDropEvent
		{
			add
			{
				CreateEventBridge();
				_OLEDragDropEvent += value;
			}
			remove
			{
				_OLEDragDropEvent -= value;
			}
		}

		#endregion

        #region IEventBinding Member
        
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public bool EventBridgeInitialized
        {
            get 
            {
                return (null != _connectPoint);
            }
        }
        
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public bool HasEventRecipients       
        {
			get
			{
				if(null == _thisType)
					_thisType = this.GetType();
					
				foreach (NetRuntimeSystem.Reflection.EventInfo item in _thisType.GetEvents())
				{
					MulticastDelegate eventDelegate = (MulticastDelegate) _thisType.GetType().GetField(item.Name, 
																			NetRuntimeSystem.Reflection.BindingFlags.NonPublic |
																			NetRuntimeSystem.Reflection.BindingFlags.Instance).GetValue(this);
					
					if( (null != eventDelegate) && (eventDelegate.GetInvocationList().Length > 0) )
						return false;
				}
				
				return false;
			}
        }
        
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public Delegate[] GetEventRecipients(string eventName)
        {
			if(null == _thisType)
				_thisType = this.GetType();
             
            MulticastDelegate eventDelegate = (MulticastDelegate)_thisType.GetField(
                                                "_" + eventName + "Event",
                                                NetRuntimeSystem.Reflection.BindingFlags.Instance |
                                                NetRuntimeSystem.Reflection.BindingFlags.NonPublic).GetValue(this);

            if (null != eventDelegate)
            {
                Delegate[] delegates = eventDelegate.GetInvocationList();
                return delegates;
            }
            else
                return new Delegate[0];
        }

        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public void DisposeSinkHelper()
        {
			if( null != _iTabStripEvents_SinkHelper)
			{
				_iTabStripEvents_SinkHelper.Dispose();
				_iTabStripEvents_SinkHelper = null;
			}

			_connectPoint = null;
		}
        
        #endregion
		#pragma warning restore
	}
}