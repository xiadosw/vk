using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using VkNet.Enums;
using VkNet.Enums.SafetyEnums;
using VkNet.Utils.JsonConverter;

namespace VkNet.Model;

/// <summary>
/// Информация о доступных пользователю функциях.
/// </summary>
[Serializable]
public class ClientInfo
{
	/// <summary>
	/// Массив кнопок, которые поддерживает клиент.
	/// </summary>
	[JsonProperty("button_actions", ItemConverterType = typeof(SafetyEnumJsonConverter))]
	public IEnumerable<KeyboardButtonActionType> ButtonActions { get; set; }

	/// <summary>
	/// Поддерживается ли клавиатура ботов клиентом.
	/// </summary>
	[JsonProperty("keyboard")]
	public bool Keyboard { get; set; }

	/// <summary>
	/// Поддерживается ли inline-клавиатура ботов клиентом.
	/// </summary>
	[JsonProperty("inline_keyboard")]
	public bool InlineKeyboard { get; set; }

	/// <summary>
	/// Id используемого языка.
	/// </summary>
	[JsonProperty("lang_id")]
	public Language LangId { get; set; }
}