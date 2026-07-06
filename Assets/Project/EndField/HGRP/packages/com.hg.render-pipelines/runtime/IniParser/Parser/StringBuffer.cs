using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;

namespace IniParser.Parser
{
	[DefaultMember("Item")]
	public sealed class StringBuffer
	{
		// (get) Token: 0x0600004B RID: 75 RVA: 0x00002608 File Offset: 0x00000808
		public int Count
		{
			get
			{
				// // Int32 get_Item4()
				// int32_t System::Tuple<System::Object,System::Object,int,int>::get_Item4(
				//         Tuple_4_Object_Object_Int32_Int32_ *this,
				//         MethodInfo *method)
				// {
				//   return this.fields.m_Item4;
				// }
				// 
				return 0;
			}
		}

		// (get) Token: 0x0600004C RID: 76 RVA: 0x000025D8 File Offset: 0x000007D8
		public bool IsEmpty
		{
			get
			{
				// // Boolean get_IsEmpty()
				// bool IniParser::Parser::StringBuffer::get_IsEmpty(StringBuffer *this, MethodInfo *method)
				// {
				//   return this.fields._bufferIndexes._size == 0;
				// }
				// 
				return default(bool);
			}
		}

		// (get) Token: 0x0600004D RID: 77 RVA: 0x000025D8 File Offset: 0x000007D8
		public bool IsWhitespace
		{
			get
			{
				// // Boolean get_IsWhitespace()
				// bool IniParser::Parser::StringBuffer::get_IsWhitespace(StringBuffer *this, MethodInfo *method)
				// {
				//   int32_t start; // edi
				//   int v4; // esi
				//   int v5; // eax
				//   List_1_System_Char_ *buffer; // rcx
				//   __int64 v7; // rdx
				//   uint16_t Item; // bp
				// 
				//   if ( !byte_18D8ED919 )
				//   {
				//     sub_18003C530(&TypeInfo::System::Char);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<wchar_t>::get_Item);
				//     byte_18D8ED919 = 1;
				//   }
				//   start = this.fields._bufferIndexes._start;
				//   v4 = 0;
				//   while ( 1 )
				//   {
				//     v5 = this.fields._bufferIndexes._size <= 0
				//        ? 0
				//        : this.fields._bufferIndexes._start + this.fields._bufferIndexes._size - 1;
				//     if ( start > v5 )
				//       break;
				//     buffer = this.fields._buffer;
				//     if ( !buffer )
				//       sub_180B536AC(0LL, method);
				//     Item = System::Collections::Generic::List<wchar_t>::get_Item(
				//              buffer,
				//              start,
				//              MethodInfo::System::Collections::Generic::List<wchar_t>::get_Item);
				//     if ( !TypeInfo::System::Char._1.cctor_finished_or_no_cctor )
				//       il2cpp_runtime_class_init_0(TypeInfo::System::Char, v7);
				//     if ( !System::Char::IsWhiteSpace(Item, 0LL) )
				//       break;
				//     ++start;
				//   }
				//   if ( this.fields._bufferIndexes._size > 0 )
				//     v4 = this.fields._bufferIndexes._size + this.fields._bufferIndexes._start - 1;
				//   return start > v4;
				// }
				// 
				return default(bool);
			}
		}

		// (get) Token: 0x0600004E RID: 78 RVA: 0x00002620 File Offset: 0x00000820
		public char Item
		{
			get
			{
				// // Char get_Item(Int32)
				// // local variable allocation has failed, the output may be wrong!
				// uint16_t IniParser::Parser::StringBuffer::get_Item(StringBuffer *this, int32_t idx, MethodInfo *method)
				// {
				//   List_1_System_Char_ *buffer; // rcx
				// 
				//   if ( !byte_18D9192D3 )
				//   {
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<wchar_t>::get_Item);
				//     byte_18D9192D3 = 1;
				//   }
				//   buffer = this.fields._buffer;
				//   if ( !buffer )
				//     sub_180B536AC(0LL, *(_QWORD *)&idx);
				//   return System::Collections::Generic::List<wchar_t>::get_Item(
				//            buffer,
				//            this.fields._bufferIndexes._start + idx,
				//            MethodInfo::System::Collections::Generic::List<wchar_t>::get_Item);
				// }
				// 
				return '\0';
			}
		}

		public StringBuffer()
		{
			// // StringBuffer()
			// void IniParser::Parser::StringBuffer::StringBuffer(StringBuffer *this, MethodInfo *method)
			// {
			//   if ( !byte_18D9192D2 )
			//   {
			//     sub_18003C530(&TypeInfo::IniParser::Parser::StringBuffer);
			//     byte_18D9192D2 = 1;
			//   }
			//   sub_180002C70(TypeInfo::IniParser::Parser::StringBuffer);
			//   IniParser::Parser::StringBuffer::StringBuffer(
			//     this,
			//     TypeInfo::IniParser::Parser::StringBuffer.static_fields.DefaultCapacity,
			//     0LL);
			// }
			// 
		}

		public StringBuffer(int capacity)
		{
			// // StringBuffer(Int32)
			// void IniParser::Parser::StringBuffer::StringBuffer(StringBuffer *this, int32_t capacity, MethodInfo *method)
			// {
			//   List_1_Beyond_Gameplay_RemoteFactory_RemoteFactoryUtil_FillBuildingCheckResultIterationContext_CoreZoneEntry_ *v5; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   List_1_System_Char_ *v8; // rbx
			//   UberPostPassUtils_ColorGradingData **v9; // rdx
			//   VolumetricPipelineRT **v10; // r8
			//   Transform **v11; // r9
			//   MeshRenderer **v12; // [rsp+50h] [rbp+28h]
			//   Vector3 *v13; // [rsp+58h] [rbp+30h]
			//   Quaternion *v14; // [rsp+60h] [rbp+38h]
			//   Vector3 *v15; // [rsp+68h] [rbp+40h]
			//   Object *v16; // [rsp+70h] [rbp+48h]
			//   Object *v17; // [rsp+78h] [rbp+50h]
			//   Object *v18; // [rsp+80h] [rbp+58h]
			//   Object *v19; // [rsp+88h] [rbp+60h]
			//   MethodInfo *v20; // [rsp+90h] [rbp+68h]
			// 
			//   if ( !byte_18D8ED918 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<wchar_t>::List);
			//     sub_18003C530(&TypeInfo::System::Collections::Generic::List<wchar_t>);
			//     byte_18D8ED918 = 1;
			//   }
			//   v5 = (List_1_Beyond_Gameplay_RemoteFactory_RemoteFactoryUtil_FillBuildingCheckResultIterationContext_CoreZoneEntry_ *)sub_180004920(TypeInfo::System::Collections::Generic::List<wchar_t>);
			//   v8 = (List_1_System_Char_ *)v5;
			//   if ( !v5 )
			//     sub_180B536AC(v7, v6);
			//   System::Collections::Generic::List<Beyond::Gameplay::RemoteFactory::RemoteFactoryUtil_FillBuildingCheckResultIterationContext::CoreZoneEntry>::List(
			//     v5,
			//     capacity,
			//     MethodInfo::System::Collections::Generic::List<wchar_t>::List);
			//   this.fields._buffer = v8;
			//   sub_1800054D0(
			//     (ILFixDynamicMethodWrapper_2 *)&this.fields._buffer,
			//     v9,
			//     v10,
			//     v11,
			//     v12,
			//     v13,
			//     v14,
			//     v15,
			//     v16,
			//     v17,
			//     v18,
			//     v19,
			//     v20);
			// }
			// 
		}

		internal StringBuffer(List<char> buffer, StringBuffer.Range bufferIndexes)
		{
		}

		public StringBuffer DiscardChanges()
		{
			// // StringBuffer DiscardChanges()
			// StringBuffer *IniParser::Parser::StringBuffer::DiscardChanges(StringBuffer *this, MethodInfo *method)
			// {
			//   List_1_System_Char_ *buffer; // rdx
			// 
			//   if ( !byte_18D9192D4 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<wchar_t>::get_Count);
			//     byte_18D9192D4 = 1;
			//   }
			//   buffer = this.fields._buffer;
			//   if ( !buffer )
			//     sub_180B536AC(this, 0LL);
			//   this.fields._bufferIndexes = IniParser::Parser::StringBuffer::Range::FromIndexWithSize(0, buffer.fields._size, 0LL);
			//   return this;
			// }
			// 
			return null;
		}

		public StringBuffer.Range FindSubstring(string subString, [MetadataOffset(Offset = "0x01F909C9")] int startingIndex = 0)
		{
			// // StringBuffer+Range FindSubstring(String, Int32)
			// StringBuffer_Range IniParser::Parser::StringBuffer::FindSubstring(
			//         StringBuffer *this,
			//         String *subString,
			//         int32_t startingIndex,
			//         MethodInfo *method)
			// {
			//   String *v5; // r13
			//   StringBuffer *v6; // rbx
			//   int stringLength; // r12d
			//   int size; // r14d
			//   int v9; // r10d
			//   StringBuffer_Range result; // rax
			//   int v11; // edx
			//   String__Fields fields; // r9
			//   int v13; // edx
			//   List_1_System_Char_ *buffer; // rbp
			//   uint16_t *p_firstChar; // rsi
			//   unsigned int v16; // r9d
			//   Char__Array *items; // r11
			//   int v18; // ecx
			// 
			//   v5 = subString;
			//   v6 = this;
			//   if ( !byte_18D8ED91A )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<wchar_t>::get_Item);
			//     byte_18D8ED91A = 1;
			//   }
			//   if ( !v5 )
			// LABEL_26:
			//     sub_180B536AC(this, subString);
			//   stringLength = v5.fields._stringLength;
			//   if ( stringLength <= 0 || v6.fields._bufferIndexes._size < stringLength )
			//     return 0LL;
			//   size = v6.fields._bufferIndexes._size;
			//   this = (StringBuffer *)(unsigned int)(startingIndex + v6.fields._bufferIndexes._start);
			//   v9 = (_DWORD)this + stringLength - 1;
			//   result = 0LL;
			//   while ( 1 )
			//   {
			//     v11 = size <= 0 ? 0 : size + v6.fields._bufferIndexes._start - 1;
			//     if ( (int)this > v11 )
			//       return result;
			//     subString = (String *)v6.fields._buffer;
			//     if ( !subString )
			//       goto LABEL_26;
			//     if ( (unsigned int)this >= LODWORD(subString[1].klass) )
			// LABEL_30:
			//       System::ThrowHelper::ThrowArgumentOutOfRange_IndexException(0LL);
			//     fields = subString.fields;
			//     if ( !*(_QWORD *)&fields )
			//       goto LABEL_26;
			//     if ( (unsigned int)this >= *(_DWORD *)(*(_QWORD *)&fields + 24LL) )
			// LABEL_29:
			//       sub_180070270(this, subString);
			//     if ( *(_WORD *)(*(_QWORD *)&fields + 2LL * (int)this + 32) == v5.fields._firstChar )
			//     {
			//       if ( size <= 0 )
			//         v13 = 0;
			//       else
			//         v13 = size + v6.fields._bufferIndexes._start - 1;
			//       if ( v9 <= v13 )
			//       {
			//         buffer = v6.fields._buffer;
			//         p_firstChar = &v5.fields._firstChar;
			//         v16 = (unsigned int)this;
			//         items = buffer.fields._items;
			//         while ( 1 )
			//         {
			//           if ( v16 - (unsigned int)this >= (__int64)v5.fields._stringLength )
			//             System::ThrowHelper::ThrowIndexOutOfRangeException(0LL);
			//           if ( items.vector[v16] != *p_firstChar )
			//             goto LABEL_15;
			//           ++v16;
			//           ++p_firstChar;
			//           subString = (String *)(v16 - (unsigned int)this);
			//           if ( (int)subString >= stringLength )
			//             break;
			//           if ( v16 >= buffer.fields._size )
			//             goto LABEL_30;
			//           items = buffer.fields._items;
			//           if ( v16 >= items.max_length.size )
			//             goto LABEL_29;
			//         }
			//         v18 = (_DWORD)this - v6.fields._bufferIndexes._start;
			//         if ( v18 >= 0 )
			//           return (StringBuffer_Range)__PAIR64__(stringLength, v18);
			//       }
			//       return result;
			//     }
			// LABEL_15:
			//     this = (StringBuffer *)(unsigned int)((_DWORD)this + 1);
			//     ++v9;
			//   }
			// }
			// 
			return default(StringBuffer.Range);
		}

		public bool ReadLine()
		{
			// // Boolean ReadLine()
			// bool IniParser::Parser::StringBuffer::ReadLine(StringBuffer *this, MethodInfo *method)
			// {
			//   List_1_System_Char_ *buffer; // rcx
			//   StringBuffer_Range v4; // rbx
			//   int i; // eax
			//   int size; // edx
			// 
			//   if ( !byte_18D8ED91B )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<wchar_t>::Add);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<wchar_t>::Clear);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<wchar_t>::get_Count);
			//     byte_18D8ED91B = 1;
			//   }
			//   if ( !this.fields._dataSource )
			//     return 0;
			//   buffer = this.fields._buffer;
			//   if ( !buffer )
			//     goto LABEL_19;
			//   ++buffer.fields._version;
			//   v4 = 0LL;
			//   buffer.fields._size = 0;
			//   method = (MethodInfo *)this.fields._dataSource;
			//   if ( !method )
			//     goto LABEL_19;
			//   for ( i = sub_18003ED00(10LL); i != 10; i = sub_18003ED00(10LL) )
			//   {
			//     if ( i != 13 )
			//     {
			//       if ( i == -1 )
			//         break;
			//       buffer = this.fields._buffer;
			//       if ( !buffer )
			//         goto LABEL_19;
			//       sub_182E74870(buffer);
			//     }
			//     method = (MethodInfo *)this.fields._dataSource;
			//     if ( !method )
			//       goto LABEL_19;
			//   }
			//   buffer = this.fields._buffer;
			//   if ( !buffer )
			// LABEL_19:
			//     sub_180B536AC(buffer, method);
			//   size = buffer.fields._size;
			//   if ( size > 0 )
			//     v4 = (StringBuffer_Range)__PAIR64__(size, 0);
			//   this.fields._bufferIndexes = v4;
			//   return buffer.fields._size > 0 || i != -1;
			// }
			// 
			return default(bool);
		}

		public void Reset(TextReader dataSource)
		{
		}

		public void Resize(StringBuffer.Range range)
		{
			// // Void Resize(StringBuffer+Range)
			// void IniParser::Parser::StringBuffer::Resize(StringBuffer *this, StringBuffer_Range range, MethodInfo *method)
			// {
			//   int32_t start; // eax
			//   int32_t v4; // r10d
			//   int v5; // r9d
			// 
			//   if ( range._start >= 0 && range._size >= 0 )
			//   {
			//     start = this.fields._bufferIndexes._start;
			//     v4 = 0;
			//     v5 = range._start + start;
			//     range._start = this.fields._bufferIndexes._size <= 0 ? 0 : start + this.fields._bufferIndexes._size - 1;
			//     if ( v5 + range._size - 1 <= range._start )
			//     {
			//       if ( v5 >= 0 )
			//         v4 = v5;
			//       this.fields._bufferIndexes._start = v4;
			//       this.fields._bufferIndexes._size = range._size;
			//     }
			//   }
			// }
			// 
		}

		public void Resize(int newSize)
		{
			// // Void Resize(Int32)
			// void IniParser::Parser::StringBuffer::Resize(StringBuffer *this, int32_t newSize, MethodInfo *method)
			// {
			//   IniParser::Parser::StringBuffer::Resize(this, 0, newSize, 0LL);
			// }
			// 
		}

		public void Resize(int startIdx, int size)
		{
			// // Void Resize(Int32, Int32)
			// void IniParser::Parser::StringBuffer::Resize(StringBuffer *this, int32_t startIdx, int32_t size, MethodInfo *method)
			// {
			//   int32_t start; // eax
			//   int32_t v5; // r10d
			//   int v6; // r9d
			//   int v7; // edx
			// 
			//   if ( startIdx >= 0 && size >= 0 )
			//   {
			//     start = this.fields._bufferIndexes._start;
			//     v5 = 0;
			//     v6 = startIdx + start;
			//     v7 = this.fields._bufferIndexes._size <= 0 ? 0 : start + this.fields._bufferIndexes._size - 1;
			//     if ( v6 + size - 1 <= v7 )
			//     {
			//       if ( v6 >= 0 )
			//         v5 = v6;
			//       this.fields._bufferIndexes._start = v5;
			//       this.fields._bufferIndexes._size = size;
			//     }
			//   }
			// }
			// 
		}

		public void ResizeBetweenIndexes(int startIdx, int endIdx)
		{
			// // Void ResizeBetweenIndexes(Int32, Int32)
			// void IniParser::Parser::StringBuffer::ResizeBetweenIndexes(
			//         StringBuffer *this,
			//         int32_t startIdx,
			//         int32_t endIdx,
			//         MethodInfo *method)
			// {
			//   int32_t v4; // r8d
			//   int32_t start; // eax
			//   int32_t v6; // r10d
			//   int v7; // r9d
			//   int v8; // edx
			// 
			//   v4 = endIdx - startIdx + 1;
			//   if ( startIdx >= 0 && v4 >= 0 )
			//   {
			//     start = this.fields._bufferIndexes._start;
			//     v6 = 0;
			//     v7 = startIdx + start;
			//     v8 = this.fields._bufferIndexes._size <= 0 ? 0 : start + this.fields._bufferIndexes._size - 1;
			//     if ( v7 + v4 - 1 <= v8 )
			//     {
			//       if ( v7 >= 0 )
			//         v6 = v7;
			//       this.fields._bufferIndexes._start = v6;
			//       this.fields._bufferIndexes._size = v4;
			//     }
			//   }
			// }
			// 
		}

		public StringBuffer Substring(StringBuffer.Range range)
		{
			// // StringBuffer Substring(StringBuffer+Range)
			// StringBuffer *IniParser::Parser::StringBuffer::Substring(
			//         StringBuffer *this,
			//         StringBuffer_Range range,
			//         MethodInfo *method)
			// {
			//   StringBuffer *result; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   int32_t start; // ecx
			//   int32_t v8; // r10d
			//   int v9; // r9d
			//   int v10; // edx
			// 
			//   result = IniParser::Parser::StringBuffer::SwallowCopy(this, 0LL);
			//   if ( !result )
			//     sub_180B536AC(v6, v5);
			//   if ( range._start >= 0 && range._size >= 0 )
			//   {
			//     start = result.fields._bufferIndexes._start;
			//     v8 = 0;
			//     v9 = range._start + start;
			//     v10 = result.fields._bufferIndexes._size <= 0 ? 0 : start + result.fields._bufferIndexes._size - 1;
			//     if ( v9 + range._size - 1 <= v10 )
			//     {
			//       if ( v9 >= 0 )
			//         v8 = range._start + start;
			//       result.fields._bufferIndexes._start = v8;
			//       result.fields._bufferIndexes._size = range._size;
			//     }
			//   }
			//   return result;
			// }
			// 
			return null;
		}

		public StringBuffer SwallowCopy()
		{
			return null;
		}

		public void TrimStart()
		{
			// // Void TrimStart()
			// void IniParser::Parser::StringBuffer::TrimStart(StringBuffer *this, MethodInfo *method)
			// {
			//   StringBuffer *v2; // rbx
			//   int start; // edi
			//   int32_t v4; // ebp
			//   int v5; // eax
			//   List_1_System_Char_ *buffer; // rax
			//   uint16_t v7; // si
			//   int v8; // eax
			//   int32_t v9; // ecx
			//   int v10; // eax
			// 
			//   v2 = this;
			//   if ( !byte_18D8ED91E )
			//   {
			//     sub_18003C530(&TypeInfo::System::Char);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<wchar_t>::get_Item);
			//     byte_18D8ED91E = 1;
			//   }
			//   if ( v2.fields._bufferIndexes._size )
			//   {
			//     start = v2.fields._bufferIndexes._start;
			//     v4 = 0;
			//     while ( 1 )
			//     {
			//       v5 = v2.fields._bufferIndexes._size <= 0
			//          ? 0
			//          : v2.fields._bufferIndexes._size + v2.fields._bufferIndexes._start - 1;
			//       if ( start > v5 )
			//         break;
			//       buffer = v2.fields._buffer;
			//       if ( !buffer )
			//         goto LABEL_24;
			//       if ( (unsigned int)start >= buffer.fields._size )
			//         System::ThrowHelper::ThrowArgumentOutOfRange_IndexException(0LL);
			//       this = (StringBuffer *)buffer.fields._items;
			//       if ( !this )
			// LABEL_24:
			//         sub_180B536AC(this, method);
			//       if ( (unsigned int)start >= LODWORD(this.fields._buffer) )
			//         sub_180070270(this, method);
			//       v7 = *((_WORD *)&this.fields._bufferIndexes._start + start);
			//       if ( !TypeInfo::System::Char._1.cctor_finished_or_no_cctor )
			//         il2cpp_runtime_class_init_0(TypeInfo::System::Char, method);
			//       if ( !System::Char::IsWhiteSpace(v7, 0LL) )
			//         break;
			//       ++start;
			//     }
			//     if ( v2.fields._bufferIndexes._size <= 0 )
			//       v8 = 0;
			//     else
			//       v8 = v2.fields._bufferIndexes._size + v2.fields._bufferIndexes._start - 1;
			//     if ( start < 0 )
			//       v9 = 0;
			//     else
			//       v9 = start;
			//     v2.fields._bufferIndexes._start = v9;
			//     v10 = v8 - start + 1;
			//     if ( v10 >= 0 )
			//       v4 = v10;
			//     v2.fields._bufferIndexes._size = v4;
			//   }
			// }
			// 
		}

		public void TrimEnd()
		{
			// // Void TrimEnd()
			// void IniParser::Parser::StringBuffer::TrimEnd(StringBuffer *this, MethodInfo *method)
			// {
			//   StringBuffer *v2; // rdi
			//   int32_t v3; // ebp
			//   int v4; // ebx
			//   List_1_System_Char_ *buffer; // rax
			//   uint16_t v6; // si
			//   int v7; // ebx
			// 
			//   v2 = this;
			//   if ( !byte_18D8ED91F )
			//   {
			//     sub_18003C530(&TypeInfo::System::Char);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<wchar_t>::get_Item);
			//     byte_18D8ED91F = 1;
			//   }
			//   if ( v2.fields._bufferIndexes._size )
			//   {
			//     v3 = 0;
			//     if ( v2.fields._bufferIndexes._size <= 0 )
			//       v4 = 0;
			//     else
			//       v4 = v2.fields._bufferIndexes._size + v2.fields._bufferIndexes._start - 1;
			//     for ( ; v4 >= v2.fields._bufferIndexes._start; --v4 )
			//     {
			//       buffer = v2.fields._buffer;
			//       if ( !buffer )
			//         goto LABEL_20;
			//       if ( (unsigned int)v4 >= buffer.fields._size )
			//         System::ThrowHelper::ThrowArgumentOutOfRange_IndexException(0LL);
			//       this = (StringBuffer *)buffer.fields._items;
			//       if ( !this )
			// LABEL_20:
			//         sub_180B536AC(this, method);
			//       if ( (unsigned int)v4 >= LODWORD(this.fields._buffer) )
			//         sub_180070270(this, method);
			//       v6 = *((_WORD *)&this.fields._bufferIndexes._start + v4);
			//       if ( !TypeInfo::System::Char._1.cctor_finished_or_no_cctor )
			//         il2cpp_runtime_class_init_0(TypeInfo::System::Char, method);
			//       if ( !System::Char::IsWhiteSpace(v6, 0LL) )
			//         break;
			//     }
			//     v7 = v4 - v2.fields._bufferIndexes._start + 1;
			//     if ( v7 >= 0 )
			//       v3 = v7;
			//     v2.fields._bufferIndexes._size = v3;
			//   }
			// }
			// 
		}

		public void Trim()
		{
			// // Void Trim()
			// void IniParser::Parser::StringBuffer::Trim(StringBuffer *this, MethodInfo *method)
			// {
			//   IniParser::Parser::StringBuffer::TrimEnd(this, 0LL);
			//   IniParser::Parser::StringBuffer::TrimStart(this, 0LL);
			// }
			// 
		}

		public bool StartsWith(string str)
		{
			// // Boolean StartsWith(String)
			// bool IniParser::Parser::StringBuffer::StartsWith(StringBuffer *this, String *str, MethodInfo *method)
			// {
			//   int32_t start; // r15d
			//   uint16_t *p_firstChar; // r14
			//   int32_t i; // esi
			//   List_1_System_Char_ *buffer; // rcx
			//   uint16_t v9; // bp
			// 
			//   if ( !byte_18D8ED920 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<wchar_t>::get_Item);
			//     byte_18D8ED920 = 1;
			//   }
			//   if ( !str || !str.fields._stringLength || !this.fields._bufferIndexes._size )
			//     return 0;
			//   start = this.fields._bufferIndexes._start;
			//   p_firstChar = &str.fields._firstChar;
			//   for ( i = 0; i < str.fields._stringLength; ++i )
			//   {
			//     if ( (unsigned int)i >= (__int64)str.fields._stringLength )
			//       System::ThrowHelper::ThrowIndexOutOfRangeException(0LL);
			//     buffer = this.fields._buffer;
			//     if ( !buffer )
			//       sub_180B536AC(0LL, str);
			//     v9 = *p_firstChar;
			//     if ( v9 != System::Collections::Generic::List<wchar_t>::get_Item(
			//                  buffer,
			//                  start,
			//                  MethodInfo::System::Collections::Generic::List<wchar_t>::get_Item) )
			//       return 0;
			//     ++p_firstChar;
			//     ++start;
			//   }
			//   return 1;
			// }
			// 
			return default(bool);
		}

		public override string ToString()
		{
			// // String ToString()
			// String *IniParser::Parser::StringBuffer::ToString(StringBuffer *this, MethodInfo *method)
			// {
			//   List_1_System_Char_ *buffer; // rcx
			//   Char__Array *v4; // rax
			// 
			//   if ( !byte_18D8ED921 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<wchar_t>::ToArray);
			//     byte_18D8ED921 = 1;
			//   }
			//   buffer = this.fields._buffer;
			//   if ( !buffer )
			//     sub_180B536AC(0LL, method);
			//   v4 = (Char__Array *)System::Collections::Generic::List<UnityEngine::InputSystem::HID::HID::HIDElementDescriptor>::ToArray(
			//                         (List_1_UnityEngine_InputSystem_HID_HID_HIDElementDescriptor_ *)buffer,
			//                         MethodInfo::System::Collections::Generic::List<wchar_t>::ToArray);
			//   return System::String::Ctor(v4, this.fields._bufferIndexes._start, this.fields._bufferIndexes._size, 0LL);
			// }
			// 
			return null;
		}

		public string ToString(StringBuffer.Range range)
		{
			// // String ToString(StringBuffer+Range)
			// String *IniParser::Parser::StringBuffer::ToString(StringBuffer *this, StringBuffer_Range range, MethodInfo *method)
			// {
			//   int32_t start; // ebx
			//   int32_t end; // eax
			//   __int64 v6; // rdx
			//   List_1_System_Char_ *buffer; // rcx
			//   Char__Array *v8; // rax
			//   int32_t size; // [rsp+4Ch] [rbp+14h]
			// 
			//   size = range._size;
			//   start = range._start;
			//   if ( !byte_18D9192D5 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<wchar_t>::ToArray);
			//     sub_18003C530(&TypeInfo::System::String);
			//     byte_18D9192D5 = 1;
			//   }
			//   if ( !size )
			//     return TypeInfo::System::String.static_fields.Empty;
			//   if ( start < 0 )
			//     return TypeInfo::System::String.static_fields.Empty;
			//   if ( size > this.fields._bufferIndexes._size )
			//     return TypeInfo::System::String.static_fields.Empty;
			//   end = IniParser::Parser::StringBuffer::Range::get_end(&this.fields._bufferIndexes, 0LL);
			//   v6 = (unsigned int)(start + this.fields._bufferIndexes._start);
			//   if ( (int)v6 > end )
			//     return TypeInfo::System::String.static_fields.Empty;
			//   buffer = this.fields._buffer;
			//   if ( !buffer )
			//     sub_180B536AC(0LL, v6);
			//   v8 = (Char__Array *)System::Collections::Generic::List<UnityEngine::InputSystem::HID::HID::HIDElementDescriptor>::ToArray(
			//                         (List_1_UnityEngine_InputSystem_HID_HID_HIDElementDescriptor_ *)buffer,
			//                         MethodInfo::System::Collections::Generic::List<wchar_t>::ToArray);
			//   return System::String::CreateString(0LL, v8, start + this.fields._bufferIndexes._start, size, 0LL);
			// }
			// 
			return null;
		}

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		private static readonly int DefaultCapacity;

		private TextReader _dataSource;

		private List<char> _buffer;

		private StringBuffer.Range _bufferIndexes;

		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 8)]
		public struct Range
		{
			// (get) Token: 0x06000063 RID: 99 RVA: 0x00002608 File Offset: 0x00000808
			// (set) Token: 0x06000064 RID: 100 RVA: 0x000025D0 File Offset: 0x000007D0
			public int start
			{
				get
				{
					// // UInt32 ReadUnaligned[UInt32](Byte ByRef)
					// uint32_t System::Runtime::CompilerServices::Unsafe::ReadUnaligned<unsigned int>(uint8_t *source, MethodInfo *method)
					// {
					//   return *(_DWORD *)source;
					// }
					// 
					return 0;
				}
				set
				{
					// // Void set_start(Int32)
					// void IniParser::Parser::StringBuffer::Range::set_start(StringBuffer_Range *this, int32_t value, MethodInfo *method)
					// {
					//   if ( value < 0 )
					//     this._start = 0;
					//   else
					//     this._start = value;
					// }
					// 
				}
			}

			// (get) Token: 0x06000065 RID: 101 RVA: 0x00002608 File Offset: 0x00000808
			// (set) Token: 0x06000066 RID: 102 RVA: 0x000025D0 File Offset: 0x000007D0
			public int size
			{
				get
				{
					// // Int32 get_endIndex()
					// int32_t Beyond::Gameplay::Factory::WireRendererInfoCollection<Beyond::Gameplay::Factory::WireRendererInfo>::get_endIndex(
					//         WireRendererInfoCollection_1_WireRendererInfo_ *this,
					//         MethodInfo *method)
					// {
					//   return this.m_endIndex;
					// }
					// 
					return 0;
				}
				set
				{
					// // Void set_size(Int32)
					// void IniParser::Parser::StringBuffer::Range::set_size(StringBuffer_Range *this, int32_t value, MethodInfo *method)
					// {
					//   if ( value < 0 )
					//     this._size = 0;
					//   else
					//     this._size = value;
					// }
					// 
				}
			}

			// (get) Token: 0x06000067 RID: 103 RVA: 0x00002608 File Offset: 0x00000808
			public int end
			{
				get
				{
					// // Int32 get_end()
					// int32_t IniParser::Parser::StringBuffer::Range::get_end(StringBuffer_Range *this, MethodInfo *method)
					// {
					//   if ( this._size <= 0 )
					//     return 0;
					//   else
					//     return this._size + this._start - 1;
					// }
					// 
					return 0;
				}
			}

			// (get) Token: 0x06000068 RID: 104 RVA: 0x000025D8 File Offset: 0x000007D8
			public bool IsEmpty
			{
				get
				{
					// // Boolean get_isEmpty()
					// bool UnityEngine::InputSystem::Utilities::MemoryHelpers::BitRegion::get_isEmpty(
					//         MemoryHelpers_BitRegion *this,
					//         MethodInfo *method)
					// {
					//   return this.sizeInBits == 0;
					// }
					// 
					return default(bool);
				}
			}

			public void Reset()
			{
				// // Void Reset()
				// void IniParser::Parser::StringBuffer::Range::Reset(StringBuffer_Range *this, MethodInfo *method)
				// {
				//   *this = 0LL;
				// }
				// 
			}

			public static StringBuffer.Range FromIndexWithSize(int start, int size)
			{
				// // StringBuffer+Range FromIndexWithSize(Int32, Int32)
				// StringBuffer_Range IniParser::Parser::StringBuffer::Range::FromIndexWithSize(
				//         int32_t start,
				//         int32_t size,
				//         MethodInfo *method)
				// {
				//   if ( start < 0 || size <= 0 )
				//     return 0LL;
				//   else
				//     return (StringBuffer_Range)__PAIR64__(size, start);
				// }
				// 
				return default(StringBuffer.Range);
			}

			public static StringBuffer.Range WithIndexes(int start, int end)
			{
				// // StringBuffer+Range WithIndexes(Int32, Int32)
				// StringBuffer_Range IniParser::Parser::StringBuffer::Range::WithIndexes(int32_t start, int32_t end, MethodInfo *method)
				// {
				//   StringBuffer_Range v4; // [rsp+20h] [rbp+20h]
				// 
				//   if ( start < 0 || end < 0 || end - start < 0 )
				//     return 0LL;
				//   v4._start = start;
				//   v4._size = end - start + 1;
				//   return v4;
				// }
				// 
				return default(StringBuffer.Range);
			}

			public override string ToString()
			{
				// // String ToString()
				// String *IniParser::Parser::StringBuffer::Range::ToString(StringBuffer_Range *this, MethodInfo *method)
				// {
				//   __int64 v2; // r8
				//   Object *v4; // rdi
				//   __int64 v5; // r8
				//   __int64 v6; // rax
				//   Object *v7; // rbx
				//   __int64 v8; // r8
				//   Object *v9; // rax
				//   int32_t start; // [rsp+40h] [rbp+8h] BYREF
				// 
				//   if ( !byte_18D9192D6 )
				//   {
				//     sub_18003C530(&TypeInfo::System::Int32);
				//     sub_18003C530(&off_18D584DD0);
				//     byte_18D9192D6 = 1;
				//   }
				//   start = this._start;
				//   v4 = (Object *)il2cpp_value_box_0(TypeInfo::System::Int32, &start, v2);
				//   start = IniParser::Parser::StringBuffer::Range::get_end(this, 0LL);
				//   v6 = il2cpp_value_box_0(TypeInfo::System::Int32, &start, v5);
				//   start = this._size;
				//   v7 = (Object *)v6;
				//   v9 = (Object *)il2cpp_value_box_0(TypeInfo::System::Int32, &start, v8);
				//   return System::String::Format((String *)"[start:{0}, end:{1} size: {2}]", v4, v7, v9, 0LL);
				// }
				// 
				return null;
			}

			private int _start;

			private int _size;
		}
	}
}
