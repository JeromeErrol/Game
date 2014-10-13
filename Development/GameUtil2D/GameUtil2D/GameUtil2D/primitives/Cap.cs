using System.Collections;
using System;

namespace GameUtil2D
{
		public class Cap
		{
				float _value;
				float _maxValue;
				float _previous;

				public Cap (float value, float maxValue)
				{
						_value = value;
						_maxValue = maxValue;
				}

				public float value {
						get {
								return _value;
						}set {
								_previous = _value;
								if (value > 0) {
										_value = Math.Min (value, _maxValue);
								} else {
										_value = 0;
								}
						}
				}

				public float previous {
						get {
								return _previous;
						}
				}

				public float difference {
						get {
								return _value - _previous;
						}
				}

				public bool IsZero {
						get {
								return value == 0;
						}
				}

				public bool IsNotZero {
						get {
								return !IsZero;
						}
				}

				public bool IsMaxed {
						get {
								return value == maxValue;
						}
				}

				public float Percent {
						get {
								return _value / _maxValue;
						}set {
								this.value = (_maxValue / 100.0f) * value;
						}
				}

				public float maxValue {
						get {
								return _maxValue;
						}set {
								_maxValue = Math.Max (value, 0);
								_value = Math.Min (_value, _maxValue);
						}
				}
		}
}
