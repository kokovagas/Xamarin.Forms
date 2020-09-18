﻿using Android.Widget;

namespace Xamarin.Platform.Handlers
{
	public partial class EntryHandler : AbstractViewHandler<IEntry, EditText>
	{
		protected override EditText CreateView()
		{
			var editText = new EditText(Context);

			return editText;
		}

		public static void MapPropertyText(IViewHandler handler, IEntry entry)
		{
			(handler as EntryHandler)?.UpdateText();
		}

		public static void MapPropertyColor(IViewHandler handler, IEntry entry)
		{

		}

		public static void MapPropertyFont(IViewHandler handler, IEntry entry)
		{

		}

		public static void MapPropertyTextTransform(IViewHandler handler, IEntry entry)
		{

		}

		public static void MapPropertyCharacterSpacing(IViewHandler handler, IEntry entry)
		{

		}

		public static void MapPropertyPlaceholder(IViewHandler handler, IEntry entry)
		{

		}

		public static void MapPropertyMaxLength(IViewHandler handler, IEntry entry)
		{

		}

		public static void MapPropertyIsReadOnly(IViewHandler handler, IEntry entry)
		{

		}

		public static void MapPropertyKeyboard(IViewHandler handler, IEntry entry)
		{

		}

		public static void MapPropertyIsSpellCheckEnabled(IViewHandler handler, IEntry entry)
		{

		}

		public static void MapPropertyPlaceholderColor(IViewHandler handler, IEntry entry)
		{

		}

		public static void MapPropertyHorizontalTextAlignment(IViewHandler handler, IEntry entry)
		{

		}

		public static void MapPropertyVerticalTextAlignment(IViewHandler handler, IEntry entry)
		{

		}

		public static void MapPropertyFontSize(IViewHandler handler, IEntry entry)
		{

		}

		public static void MapPropertyFontAttributes(IViewHandler handler, IEntry entry)
		{

		}

		public static void MapPropertyIsPassword(IViewHandler handler, IEntry entry)
		{

		}

		public static void MapPropertyReturnType(IViewHandler handler, IEntry entry)
		{

		}

		public static void MapPropertyCursorPosition(IViewHandler handler, IEntry entry)
		{

		}

		public static void MapPropertySelectionLength(IViewHandler handler, IEntry entry)
		{

		}

		public static void MapPropertyIsTextPredictionEnabled(IViewHandler handler, IEntry entry)
		{

		}

		public static void MapPropertyClearButtonVisibility(IViewHandler handler, IEntry entry)
		{

		}

		void UpdateText()
		{
			var text = VirtualView.UpdateTransformedText(VirtualView.Text, VirtualView.TextTransform);

			if (TypedNativeView.Text == text)
				return;

			TypedNativeView.Text = text;

			if (TypedNativeView.IsFocused)
			{
				TypedNativeView.SetSelection(text.Length);
				// TODO: Port KeyboardManager to Xamarin.Platform.
				//TypedNativeView.ShowKeyboard();
			}
		}
	}
}